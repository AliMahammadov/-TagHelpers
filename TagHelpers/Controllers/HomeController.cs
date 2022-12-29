using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
