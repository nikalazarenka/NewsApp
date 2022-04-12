using System;

namespace NewsApp.Data.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageData { get; set; }
        public string Text { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
