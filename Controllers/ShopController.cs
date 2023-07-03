using inventory_management.Data;
using Microsoft.AspNetCore.Mvc;

namespace inventory_management.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var shop = _context.Shops.ToList();
            return View(shop);
        }
    }
}
