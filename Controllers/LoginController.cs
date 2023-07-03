using Microsoft.AspNetCore.Mvc;

namespace inventory_management.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
