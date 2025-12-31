using Microsoft.AspNetCore.Mvc;

namespace Error.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
