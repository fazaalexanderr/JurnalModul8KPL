using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204062.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
