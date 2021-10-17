using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using Data.DbInfo;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Services
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _dbContext;

        public BookService(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBookWithAuthors(BookViewModel bookVm)
        {
            var book = new Book()
            {
                Title = bookVm.Title,
                UrlPath = bookVm.UrlPath,
                Genre = bookVm.Genre,
                IsRead = bookVm.IsRead,
                Description = bookVm.Description,
                DateRead = bookVm.IsRead ? bookVm.DateRead.Value : null,
                Rate = bookVm.IsRead ? bookVm.Rate.Value : null,
                DateAdded = DateTime.Now,
                PublisherId = bookVm.PublisherId
            };
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            foreach (var id in bookVm.AuthorsListId)
            {
                var bookAuthor = new BookAuthor()
                {
                    BookId = book.Id,
                    AuthorId = id
                };
                _dbContext.BookAuthors.Add(bookAuthor);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteBookById(int bookId)
        {
            var book = _dbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if(book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }


        public Book GetBookById(int bookId)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == bookId);
        }

        public Book UpdateBookById(int bookId, BookViewModel bookVm)
        {
            var book = _dbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if(book != null)
            {
                book.Title = bookVm.Title;
                book.UrlPath = bookVm.UrlPath;
                book.Genre = bookVm.Genre;
                book.Description = bookVm.Description;
                book.DateRead = bookVm.IsRead ? bookVm.DateRead.Value : null;
                book.Rate = bookVm.IsRead ? bookVm.Rate.Value : null;
                book.IsRead = bookVm.IsRead;

                _dbContext.SaveChanges();
            }
            return book;
        }
    }
}
