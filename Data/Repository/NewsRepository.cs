using NewsApp.Data.Interfaces;
using NewsApp.Data.Models;
using System.Collections.Generic;
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

        public News getNewsById(int? newsId) => appDbContext.News.FirstOrDefault(t => t.Id == newsId);
    }
}
