namespace SoftUniBazar.Services.Interfaces
{
    using System.Collections.Generic;
    using SoftUniBazar.Data.Models;

    public interface ICategoryService
    {
        List<Category> GetAllCategories();
    }
}