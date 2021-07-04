using System;

namespace Books.API.Models
{
    public class Book
    {
        public string Id { get; set; }
        public DateTime PublishedDate { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }  
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

    }
}