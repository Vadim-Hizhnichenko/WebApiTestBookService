using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using Data.DbInfo;
using Data.Models;
using System.Linq;

namespace BusinessLayer.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BookDbContext _bookDbContex;

        public AuthorService(BookDbContext bookDbContex)
        {
            _bookDbContex = bookDbContex;
        }

        public void AddAuthor(AuthorViewModel authorVm)
        {
            var author = new Author()
            {
                FullName = authorVm.FullName
            };

            _bookDbContex.Authors.Add(author);
            _bookDbContex.SaveChanges();
        }

        public AuthorWithBookViewModel GetAuthorWithBooks(int authorId)
        {
            var author = _bookDbContex.Authors.Where(n => n.Id == authorId).Select(a => new AuthorWithBookViewModel()
            {
                FullName = a.FullName,
                BookTitles = a.ListOfBookAuthors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return author;
        }
    }
}
