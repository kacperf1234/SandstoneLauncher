using Microsoft.AspNetCore.Mvc;

namespace SandstoneLauncher.App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("start")]
        public IActionResult Start()
        {
            return Content("Hello!");
        }
    }
}