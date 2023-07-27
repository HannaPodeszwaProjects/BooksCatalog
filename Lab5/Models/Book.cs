using System;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string? Rating { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }
        //public decimal Price { get; set; }
    }
}
