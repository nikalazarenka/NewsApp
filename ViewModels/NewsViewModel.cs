using NewsApp.Data.Models;
using System.Collections.Generic;

namespace NewsApp.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<News> News { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
