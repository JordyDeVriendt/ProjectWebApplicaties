using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class WinkelmandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
