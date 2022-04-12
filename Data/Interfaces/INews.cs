using NewsApp.Data.Models;
using System.Collections.Generic;

namespace NewsApp.Data.Interfaces
{
    public interface INews
    {
        IEnumerable<News> News { get; }

        News getNewsById(int? newsId);

    }
}
