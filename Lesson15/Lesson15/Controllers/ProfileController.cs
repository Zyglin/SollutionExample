using Microsoft.AspNetCore.Mvc;

namespace Lesson15.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Road()
        {
            return View();
        }
    }
}
