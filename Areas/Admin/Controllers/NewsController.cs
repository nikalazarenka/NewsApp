using Microsoft.AspNetCore.Http;
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
    public class NewsController : Controller
    {
        private readonly INews _newsRepository;

        public NewsController(INews newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                News _news = _newsRepository.getNewsById(id);
                if(_news != null)
                {
                    var news = new OneNewsViewModel
                    {
                        News = _news
                    };

                    return View(news);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            _newsRepository.Delete(id);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string subtitle, IFormFile image, string text)
        {
            _newsRepository.Create(title, subtitle, image, text);
            return RedirectToAction("Index", "Home");
        }
    }
}
