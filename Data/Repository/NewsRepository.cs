using Microsoft.AspNetCore.Http;
using NewsApp.Data.Interfaces;
using NewsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewsApp.Data.Repositories
{
    public class NewsRepository : INews
    {
        private readonly AppDbContext appDbContext;
        public NewsRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<News> News => appDbContext.News;

        public void Create(News news)
        {
            appDbContext.News.Add(news);
            appDbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            News news = getNewsById(id);
            if (news != null)
            {
                appDbContext.News.Remove(news);
                appDbContext.SaveChanges();
            }
        }

        public void Edit(News news)
        {
            appDbContext.News.Update(news);
            appDbContext.SaveChanges();
        }

        public News getNewsById(int? newsId) => appDbContext.News.FirstOrDefault(n => n.Id == newsId);
    }
}
