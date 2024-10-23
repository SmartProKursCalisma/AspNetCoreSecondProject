using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSecondProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
