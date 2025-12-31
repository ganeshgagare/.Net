using Microsoft.AspNetCore.Mvc;

namespace _03Demo_BasicsMVC.Controllers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
