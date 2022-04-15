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

        public void Create(string title, string subtitle, IFormFile image, string text)
        {
            string imageData = string.Empty;
            using (var stream = new MemoryStream())
            {
                image.CopyTo(stream);
                imageData = Convert.ToBase64String(stream.ToArray());
            }

            News news = new News
            {
                Title = title,
                Subtitle = subtitle,
                Text = text,
                ImageData = imageData
            };

            appDbContext.News.Add(news);
            appDbContext.SaveChanges();
        }

        public void Create(string title, string subtitle, string imageData, string text)
        {
            throw new NotImplementedException();
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

        public News getNewsById(int? newsId) => appDbContext.News.FirstOrDefault(n => n.Id == newsId);
    }
}
