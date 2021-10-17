using BusinessLayer.ViewModels;

namespace BusinessLayer.Interfaces
{
    public interface IAuthorService
    {
        void AddAuthor(AuthorViewModel authorVm);

        AuthorWithBookViewModel GetAuthorWithBooks(int authorId);

    }
}
