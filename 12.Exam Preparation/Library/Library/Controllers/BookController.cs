using Library.Services.Data.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public async Task<IActionResult> All()
        {
            var model = await this.bookService.GetAllBooksAsync();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = await this.bookService.GetMyBooksBooksAsync(GetUserId());

            return View(model);
        }
    }
}
