namespace SoftUniBazar.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using SoftUniBazar.Data;
    using SoftUniBazar.Data.Models;
    using SoftUniBazar.Services.Interfaces;


    public class CategoryService : ICategoryService
    {
        private readonly BazarDbContext _context;

        public CategoryService(BazarDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
    }
}