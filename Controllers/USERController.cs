using Microsoft.AspNetCore.Mvc;

namespace _5Pages.Controllers
{
    public class USERController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult ContactUS()
        {
            return View();
        }
        public IActionResult Carear()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
    }
}
