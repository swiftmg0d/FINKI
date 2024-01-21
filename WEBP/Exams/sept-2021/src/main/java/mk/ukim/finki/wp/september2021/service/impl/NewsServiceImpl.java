package mk.ukim.finki.wp.september2021.service.impl;

import mk.ukim.finki.wp.september2021.model.News;
import mk.ukim.finki.wp.september2021.model.NewsType;
import mk.ukim.finki.wp.september2021.model.exceptions.InvalidNewsIdException;
import mk.ukim.finki.wp.september2021.repository.NewsCategoryRepository;
import mk.ukim.finki.wp.september2021.repository.NewsRepository;
import mk.ukim.finki.wp.september2021.service.NewsCategoryService;
import mk.ukim.finki.wp.september2021.service.NewsService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class NewsServiceImpl implements NewsService {
    private final NewsRepository newsRepository;
    private final NewsCategoryService newsCategoryService;
    private final NewsCategoryRepository newsCategoryRepository;

    public NewsServiceImpl(NewsRepository newsRepository, NewsCategoryService newsCategoryService, NewsCategoryRepository newsCategoryRepository) {
        this.newsRepository = newsRepository;
        this.newsCategoryService = newsCategoryService;
        this.newsCategoryRepository = newsCategoryRepository;
    }

    @Override
    public List<News> listAllNews() {
        return newsRepository.findAll();
    }

    @Override
    public News findById(Long id) {
        return newsRepository.findById(id).orElseThrow(InvalidNewsIdException::new);
    }

    @Override
    public News create(String name, String description, Double price, NewsType type, Long category) {
        return newsRepository.save(new News(name,description,price,type,newsCategoryService.findById(category)));
    }

    @Override
    public News update(Long id, String name, String description, Double price, NewsType type, Long category) {
        News updatedNews=findById(id);
        updatedNews.setName(name);
        updatedNews.setDescription(description);
        updatedNews.setPrice(price);
        updatedNews.setType(type);
        updatedNews.setCategory(newsCategoryService.findById(category));
        return newsRepository.save(updatedNews);
    }

    @Override
    public News delete(Long id) {
        News deletedNews=findById(id);
        newsRepository.delete(deletedNews);
        return deletedNews;
    }

    @Override
    public News like(Long id) {
        News likedNews=findById(id);
        likedNews.setLikes(likedNews.getLikes()+1);
        return newsRepository.save(likedNews);
    }

    @Override
    public List<News> listNewsWithPriceLessThanAndType(Double price, NewsType type) {
        if(price!=null && type!=null){
            return newsRepository.findAllByTypeEqualsAndPriceLessThanEqual(type,price);
        }else if(price!=null){
            return newsRepository.findAllByPriceLessThanEqual(price);
        }else if(type!=null){
            return newsRepository.findAllByTypeEquals(type);
        }
        return listAllNews();
    }
}
