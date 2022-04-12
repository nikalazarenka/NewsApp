using Microsoft.AspNetCore.Mvc;
using NewsApp.Data.Interfaces;
using NewsApp.ViewModels;

namespace NewsApp.Controllers
{
    public class MoreController : Controller
    {
        private readonly INews _newsRepository;
        public MoreController(INews newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public ViewResult Index(int? id)
        {
            var _news = _newsRepository.getNewsById(id);
            var news = new OneNewsViewModel
            {
                News = _news
            };

            return View(news);
        }
    }
}
