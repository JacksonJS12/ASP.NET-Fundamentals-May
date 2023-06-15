using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemoo.Controllers
{
    public class ProductController1 : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
