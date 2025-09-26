using Blogg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogg.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var news = new List<News>
            {
                new News { Id = 1, Title = "Первая новость", Content = "Содержимое первой новости" },
                new News { Id = 2, Title = "Вторая новость", Content = "Содержимое второй новости" },
                new News { Id = 3, Title = "Третья новость", Content = "Содержимое третьей новости" }
            };

            return View(news);
        }
    }
}
