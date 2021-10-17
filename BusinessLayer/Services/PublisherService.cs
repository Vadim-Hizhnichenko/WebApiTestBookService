using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using Data.DbInfo;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly BookDbContext _bookDbContext;

        public PublisherService(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }

        public void AddPublisher(PublisherViewModel publisherVm)
        {
            var publisher = new Publisher()
            {
                Name = publisherVm.Name
            };
            _bookDbContext.Publishers.Add(publisher);
            _bookDbContext.SaveChanges();
        }

        public void DeletePublisherById(int id)
        {
            var publisher = _bookDbContext.Publishers.FirstOrDefault(x => x.Id == id);

            if(publisher != null)
            {
                _bookDbContext.Publishers.Remove(publisher);
                _bookDbContext.SaveChanges();
            }
        }

        public Publisher GetPublisherById(int id)
        {
            return _bookDbContext.Publishers.FirstOrDefault(n => n.Id == id);
        }

        public PublisherWithBooksAndAuthorsViewModel GetPublisherData(int publisherId)
        {
            var publisherData = _bookDbContext.Publishers.Where(n => n.Id == publisherId).Select(a => new PublisherWithBooksAndAuthorsViewModel()
            {
                Name = a.Name,
                BookAuthors = a.BooksList.Select(n => new BookAuthorViewModel()
                {
                    BookName = n.Title,
                    BookAuthors = n.ListOfBookAuthors.Select(n => n.Author.FullName).ToList()
                }).ToList()
            }).FirstOrDefault();

            return publisherData;
        }
    }
}
