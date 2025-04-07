using Microsoft.AspNetCore.Mvc;
using MiniECommerce.Models;

namespace MiniECommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Kulaklık", Description = "Kablosuz bluetooth kulaklık", Price = 499, ImageUrl = "/images/kulaklık1.jpg" },
                new Product { Id = 2, Name = "Klavye", Description = "Mekanik klavye", Price = 899, ImageUrl = "/images/klavye.jpg" },
                new Product { Id = 3, Name = "Mouse", Description = "Oyuncu mouse", Price = 299, ImageUrl = "/images/mouse.jpg" }
            };

            return View(products);
        }
    }
}
