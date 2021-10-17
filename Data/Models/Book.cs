using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Book
    {
        //[Key]
        public int Id { get; set; }
        public string Title {get; set;}
        public string Genre { get; set; }
        public string Description { get; set; }
        public int? Rate { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime DateAdded { get; set; }
        public string UrlPath { get; set; }


        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthor> ListOfBookAuthors { get; set; }

    }
}
