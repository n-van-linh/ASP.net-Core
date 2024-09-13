using Microsoft.AspNetCore.Mvc;

namespace LINH.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
