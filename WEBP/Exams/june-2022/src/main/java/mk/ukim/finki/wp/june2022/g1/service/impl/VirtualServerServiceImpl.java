package mk.ukim.finki.wp.june2022.g1.service.impl;

import mk.ukim.finki.wp.june2022.g1.model.OSType;
import mk.ukim.finki.wp.june2022.g1.model.VirtualServer;
import mk.ukim.finki.wp.june2022.g1.model.exceptions.InvalidUserIdException;
import mk.ukim.finki.wp.june2022.g1.model.exceptions.InvalidVirtualMachineIdException;
import mk.ukim.finki.wp.june2022.g1.repository.UserRepository;
import mk.ukim.finki.wp.june2022.g1.repository.VirtualServerRepository;
import mk.ukim.finki.wp.june2022.g1.service.UserService;
import mk.ukim.finki.wp.june2022.g1.service.VirtualServerService;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class VirtualServerServiceImpl implements VirtualServerService {
    private final VirtualServerRepository virtualServerRepository;
    private final UserService userService;
    private final UserRepository userRepository;

    public VirtualServerServiceImpl(VirtualServerRepository virtualServerRepository, UserService userService, UserRepository userRepository) {
        this.virtualServerRepository = virtualServerRepository;
        this.userService = userService;
        this.userRepository = userRepository;
    }

    @Override
    public List<VirtualServer> listAll() {
        return virtualServerRepository.findAll();
    }

    @Override
    public VirtualServer findById(Long id) {
        return virtualServerRepository.findById(id).orElseThrow(InvalidVirtualMachineIdException::new);
    }

    @Override
    public VirtualServer create(String name, String ipAddress, OSType osType, List<Long> owners, LocalDate launchDate) {
        if (userRepository.findAllById(owners).isEmpty()) throw new InvalidUserIdException();
        return virtualServerRepository.save(new VirtualServer(name, ipAddress, osType, userRepository.findAllById(owners), launchDate));
    }

    @Override
    public VirtualServer update(Long id, String name, String ipAddress, OSType osType, List<Long> owners) {
        VirtualServer updatedVirtualServer = findById(id);
        if (userRepository.findAllById(owners).isEmpty()) throw new InvalidUserIdException();
        updatedVirtualServer.setInstanceName(name);
        updatedVirtualServer.setIpAddress(ipAddress);
        updatedVirtualServer.setOSType(osType);
        updatedVirtualServer.setOwners(userRepository.findAllById(owners));
        return virtualServerRepository.save(updatedVirtualServer);
    }

    @Override
    public VirtualServer delete(Long id) {
        VirtualServer deletedVirtualServer=findById(id);
        virtualServerRepository.delete(deletedVirtualServer);
        return deletedVirtualServer;
    }

    @Override
    public VirtualServer markTerminated(Long id) {
        VirtualServer markTerminatedVirtualServer=findById(id);
        markTerminatedVirtualServer.setTerminated(true);
        return virtualServerRepository.save(markTerminatedVirtualServer);
    }

    @Override
    public List<VirtualServer> filter(Long ownerId, Integer activeMoreThanDays) {
        if(ownerId!=null && activeMoreThanDays!=null){
            return virtualServerRepository.findVirtualServersByLaunchDateIsLessThanAndOwnersContains(LocalDate.now().minusDays((long)activeMoreThanDays),userService.findById(ownerId));
        }else if(ownerId!=null){
            return virtualServerRepository.findVirtualServersByOwnersContains(userService.findById(ownerId));
        }else if(activeMoreThanDays!=null){
            return virtualServerRepository.findVirtualServersByLaunchDateIsLessThan(LocalDate.now().minusDays((long)activeMoreThanDays));
        }
        return listAll();
    }
}
