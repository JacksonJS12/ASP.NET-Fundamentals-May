namespace SoftUniBazar.Controllers
{
    using System.Linq;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SoftUniBazar.Data.Models;
    using SoftUniBazar.Models.Ad;
    using SoftUniBazar.Services.Interfaces;

    public class AdController : Controller
    {
        private readonly IAdService _adService;
        private readonly ICategoryService _categoryService;

        public AdController(IAdService adService, ICategoryService categoryService)
        {
            _adService = adService;
            _categoryService = categoryService;
        }

        public IActionResult All()
        {
            var allAds = _adService.GetAllAds();

            return View(allAds);
        }

        [Authorize]
        public IActionResult Cart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var adsInCart = _adService.GetAdsInCartForUser(userId);

            var viewModel = new CartViewModel
            {
                AdsInCart = adsInCart.ToList()
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = _categoryService.GetAllCategories().ToList();

            var viewModel = new AddAdViewModel
            {
                Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(AddAdViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var ad = new Ad
                {
                    Name = viewModel.Name,
                    Description = viewModel.Description,
                    ImageUrl = viewModel.ImageUrl,
                    Price = viewModel.Price,
                    CategoryId = viewModel.CategoryId,
                    OwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier)
                };

                _adService.AddAd(ad);

                return RedirectToAction(nameof(All));
            }

            var categories = _categoryService.GetAllCategories().ToList();
            viewModel.Categories = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            return View(viewModel);
        }
    }
}
