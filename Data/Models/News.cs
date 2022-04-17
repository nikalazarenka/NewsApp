using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsApp.Data.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 30 characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "String length must be between 3 and 80 characters")]
        public string Subtitle { get; set; }

        public string ImageData { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime PublicationDate { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Image { get; set; }

    }
}
