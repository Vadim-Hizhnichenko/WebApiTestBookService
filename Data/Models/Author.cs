using System.Collections.Generic;

namespace Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public List<BookAuthor> ListOfBookAuthors { get; set; }
    }
}
