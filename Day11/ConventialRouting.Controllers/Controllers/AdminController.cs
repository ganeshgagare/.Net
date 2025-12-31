using Microsoft.AspNetCore.Mvc;

namespace ConventialRouting.Controllers.Controllers
{
    public class AdminController : Controller
    {
        public string Index(string nm)
        {
            return nm;
        }
    }
}
