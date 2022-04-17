using Microsoft.AspNetCore.Mvc;
using NewsApp.Data.Interfaces;
using NewsApp.Data.Models;
using NewsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly INews _newsRepository;

        public HomeController(INews newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public ViewResult Index()
        {
            IQueryable<News> _news = (IQueryable<News>)_newsRepository.News;
            if (_news.Count() > 3)
            {
                _news = _news.OrderByDescending(n=>n.PublicationDate).Take(3);
            }

            var news = new NewsViewModel
            {
                News = _news
            };

            return View(news);
        }
    }
}
