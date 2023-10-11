using Library.Web.ViewModels;
using Library.Web.ViewModels.Home;

namespace Library.Services.Data.Models.Interfaces
{
    public interface IBookService
    {
        Task AddBookToCollectionAsync(string userId, BookViewModel book);
        Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
        Task<BookViewModel?> GetBookIdAsync(int id);
        Task<IEnumerable<AllBookViewModel>> GetMyBooksBooksAsync(string userId);
        Task<AddBookViewModel> GetNewAddBookModelAsync();
        Task RemoveBookToCollectionAsync(string userId, BookViewModel book);
        Task AddBookAsync(AddBookViewModel model);
    }
}
