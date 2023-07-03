using inventory_management.Data;
using Microsoft.AspNetCore.Mvc;

namespace inventory_management.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var order = _context.Orders.ToList();
            return View(order);
        }
    }
}
