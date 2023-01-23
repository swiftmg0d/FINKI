package PhoneBookTest;

import java.util.*;
    import java.util.stream.Collectors;

    public class PhoneBookTest {

        public static void main(String[] args) {
            PhoneBook phoneBook = new PhoneBook();
            Scanner scanner = new Scanner(System.in);
            int n = scanner.nextInt();
            scanner.nextLine();
            for (int i = 0; i < n; ++i) {
                String line = scanner.nextLine();
                String[] parts = line.split(":");
                try {
                    phoneBook.addContact(parts[0], parts[1]);
                } catch (DuplicateNumberException e) {
                    System.out.println(e.getMessage());
                }
            }
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                System.out.println(line);
                String[] parts = line.split(":");
                if (parts[0].equals("NUM")) {
                    phoneBook.contactsByNumber(parts[1]);
                } else {
                    phoneBook.contactsByName(parts[1]);
                }
            }
        }

    }

    class Contact {
        private String name;
        private String number;

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getNumber() {
            return number;
        }

        public void setNumber(String number) {
            this.number = number;
        }

        public Contact(String name, String number) {
            this.name = name;
            this.number = number;
        }

        public boolean check(String nNumber) {
            int cnt=0;
            for (int i = 0; i < number.length(); i++) {
                if(number.charAt(i)==nNumber.charAt(cnt)){
                    cnt++;
                }else{
                    cnt=0;
                }
                if(cnt==nNumber.length()){
                    return true;
                }
            }
            return false;
        }

        @Override
        public String toString() {
            return name + " " + number;
        }
    }

    class DuplicateNumberException extends Exception {
        public DuplicateNumberException(String message) {
            super(message);
        }
    }

    class PhoneBook {
        Map<String, List<Contact>> contactMap = new HashMap<>();

        public void addContact(String part, String part1) throws DuplicateNumberException {
            List<Contact> contactList = contactMap.computeIfAbsent(part, i -> new ArrayList<>());
            contactList.add(new Contact(part, part1));
        }

        public void contactsByNumber(String part) {
            List<Contact>contactList=contactMap.values().stream().flatMap(Collection::stream).
                    sorted(Comparator.comparing(Contact::getName).
                            thenComparing(Contact::getNumber))
                                    .filter(i->i.check(part))
                                            .collect(Collectors.toList());
            
           Map<String,List<Contact>>stringListMap=new HashMap<>();
           stringListMap.putIfAbsent(part,contactList);

            if(stringListMap.get(part).size()==0){
                System.out.println("NOT FOUND");
            }else{
                stringListMap.get(part).forEach(i->{
                    System.out.println(i.toString());
                });
            }
        }

        public void contactsByName(String part) {
            if (contactMap.get(part) == null) {
                System.out.println("NOT FOUND");
            } else {
                contactMap.get(part).stream().sorted(Comparator.comparing(Contact::getName).
                        thenComparing(Contact::getNumber)).forEach(i -> {
                    System.out.println(i.toString());
                });
            }

        }
    }
