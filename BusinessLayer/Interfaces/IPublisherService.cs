using BusinessLayer.ViewModels;
using Data.Models;

namespace BusinessLayer.Interfaces
{
    public interface IPublisherService
    {
        void AddPublisher(PublisherViewModel publisherVm);

        PublisherWithBooksAndAuthorsViewModel GetPublisherData(int publisherId);
        void DeletePublisherById(int id);

        Publisher GetPublisherById(int id);

    }
}
