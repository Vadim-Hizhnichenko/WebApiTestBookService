using System;
using System.Collections.Generic;

namespace BusinessLayer.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int? Rate { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public string UrlPath { get; set; }

        public int PublisherId { get; set; }
        public List<int> AuthorsListId { get; set; }
    }
}
