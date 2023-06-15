using MVCIntroDemoo.ViewModels.Product;

namespace MVCIntroDemoo.Seeding
{
    public static class ProductsData
    {
        public static IEnumerable<ProductViewModel> Producs =
            new List<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    Id = new Guid(),
                    Name = "Cheese",
                    Price = 7.00m
                }
            };
    }
}
