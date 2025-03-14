using Microsoft.AspNetCore.Mvc;

namespace MyAspProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
