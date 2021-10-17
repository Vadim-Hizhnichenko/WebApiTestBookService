using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class PublisherWithBooksAndAuthorsViewModel
    {
        public string Name { get; set; }
        public List<BookAuthorViewModel> BookAuthors { get; set; }

    }
}
