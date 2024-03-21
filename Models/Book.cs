using System;
using System.ComponentModel.DataAnnotations; // Add this namespace

namespace AmazonWoods23.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }


        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = null!;


        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; } = null!;


        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher { get; set; } = null!;


        [Required(ErrorMessage = "ISBN is required")]
        public string Isbn { get; set; } = null!;


        [Required(ErrorMessage = "Classification is required")]
        public string Classification { get; set; } = null!;


        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } = null!;


        [Required(ErrorMessage = "Page count is required")]
        public int PageCount { get; set; }


        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

    }
}
