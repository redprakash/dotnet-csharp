using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult MyBlog()
        {
            return View();
        }
    }
}
