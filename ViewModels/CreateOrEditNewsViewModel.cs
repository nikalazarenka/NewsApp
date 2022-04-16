using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace NewsApp.ViewModels
{
    public class CreateOrEditNewsViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        public string ImageData { get; set; }
    }
}
