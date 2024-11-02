using Microsoft.AspNetCore.Mvc;

namespace MapRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
