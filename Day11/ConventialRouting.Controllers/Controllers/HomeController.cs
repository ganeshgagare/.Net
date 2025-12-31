using Microsoft.AspNetCore.Mvc;

namespace ConventialRouting.Controllers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<string> UserCredentials(string unm, string pwd)
        {
            return $"UserName: {unm}, Password: {pwd}";
        }
    }
}
