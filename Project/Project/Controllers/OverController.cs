using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class OverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
