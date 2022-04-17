using Microsoft.AspNetCore.Mvc;
using NewsApp.Data.Interfaces;
using NewsApp.Data.Models;
using NewsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly INews _newsRepository;

        public HomeController(INews newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public ViewResult Index(int page = 1)
        {
            int pageSize = 6;

            IQueryable<News> _news = (IQueryable<News>)_newsRepository.News;
            var count = _news.Count();
            var items = _news.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            var news = new NewsViewModel
            {
                News = items,
                PageViewModel = pageViewModel
            };

            return View(news);
        }
    }
}
