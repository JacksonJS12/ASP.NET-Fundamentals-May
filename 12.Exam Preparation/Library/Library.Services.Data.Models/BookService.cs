using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Library.Services.Data.Models.Interfaces;
using Library.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Data.Models
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext dbContext;

        public BookService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync()
        {
            return await this.dbContext
                .Books
                .Select(b => new AllBookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    ImageUrl = b.ImageUrl,
                    Rating = b.Rating,
                    Category = b.Category.Name,
                }).ToArrayAsync();
        }

        public async Task<IEnumerable<AllBookViewModel>> GetMyBooksBooksAsync(string userId)
        {
            return await dbContext.IdentityUserBooks
                .Where(ub => ub.CollectorId == userId)
                .Select(b => new AllBookViewModel
                {
                    Id = b.Book.Id,
                    Title = b.Book.Title,
                    Author = b.Book.Author,
                    ImageUrl = b.Book.ImageUrl,
                    Description = b.Book.Description,
                    Category = b.Book.Category.Name
                }).ToListAsync();
        }
    }
}
