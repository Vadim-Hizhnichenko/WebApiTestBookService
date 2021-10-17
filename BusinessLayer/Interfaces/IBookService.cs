using BusinessLayer.ViewModels;
using Data.Models;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface IBookService
    {
        void AddBookWithAuthors(BookViewModel bookVm);
        List<Book> GetAllBooks();
        Book GetBookById(int bookId);
        Book UpdateBookById(int bookId, BookViewModel bookVm);
        void DeleteBookById(int bookId);

    }
}
