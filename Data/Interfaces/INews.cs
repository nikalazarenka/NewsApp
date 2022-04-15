using Microsoft.AspNetCore.Http;
using NewsApp.Data.Models;
using System.Collections.Generic;

namespace NewsApp.Data.Interfaces
{
    public interface INews
    {
        IEnumerable<News> News { get; }

        News getNewsById(int? newsId);

        public void Delete(int? id);

        public void Create(string title, string subtitle, IFormFile image, string text);

    }
}
