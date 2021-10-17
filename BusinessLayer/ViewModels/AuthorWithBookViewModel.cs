using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class AuthorWithBookViewModel
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
