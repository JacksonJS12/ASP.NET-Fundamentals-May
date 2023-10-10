using Library.Web.ViewModels.Home;

namespace Library.Services.Data.Models.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
        Task<IEnumerable<AllBookViewModel>> GetMyBooksBooksAsync(string userId);
    }
}
