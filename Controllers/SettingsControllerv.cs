using Microsoft.AspNetCore.Mvc;

namespace Blogg.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var theme = Request.Cookies["Theme"] ?? "light";
            ViewBag.Theme = theme;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string theme)
        {
            Response.Cookies.Append("Theme", theme, new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddYears(1)
            });

            return RedirectToAction("Index", "Blog");
        }
    }
}
