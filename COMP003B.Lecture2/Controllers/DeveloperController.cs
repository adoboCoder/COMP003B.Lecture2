using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Lecture2.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
