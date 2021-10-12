using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title {get; set;}
        public string Author { get; set; }
        public string Genre { get; set; }
        public int? Rate { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime DateAdded { get; set; }
        public string UrlPath { get; set; }

    }
}
