using inventory_management.Data;
using Microsoft.AspNetCore.Mvc;

namespace inventory_management.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;
        public CustomerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }
    }
}
