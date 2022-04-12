using NewsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<News> News { get; set; }
    }
}
