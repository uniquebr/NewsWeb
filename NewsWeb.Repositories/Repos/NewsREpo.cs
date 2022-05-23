﻿using Microsoft.EntityFrameworkCore;
using NewsWeb.Data;
using NewsWeb.Models;
using NewsWeb.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWeb.Repositories.Repos
{
    public class NewsRepo : INewsInterface
    {

        private readonly ApplicationDbContext _dbContext;

        public NewsRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<News> AddNewsAsync(News news)
        {

            _dbContext.News.Add(news);
            _dbContext.SaveChanges();
            return Task.FromResult(news);
        }

        public Task DeleteNewsAsync(Guid newsId)
        {
            _dbContext.News.Remove(_dbContext.News.FirstOrDefault(p => p.Id == newsId));
            _dbContext.SaveChanges();
            return Task.FromResult(0);
        }

        public Task<List<News>> GetAllNewsAsync() =>
            _dbContext.News.ToListAsync();


        public Task<News> GetNewsAsync(Guid newsId) =>
            _dbContext.News.FirstOrDefaultAsync(p => p.Id == newsId);

        public Task<News> UpdateNewsAsync(News newsId)
        {

            _dbContext.News.Update(newsId);
            _dbContext.SaveChanges();
            return Task.FromResult(newsId);
        }
    }
}