using FluentVald.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentVald.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee Employee)
        {
            if (!ModelState.IsValid)
            {
                return View(Employee);
            }
            return View(Employee);
        }
    }
}
