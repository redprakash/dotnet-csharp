using BulkyBooksWeb.Data;
using BulkyBooksWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            // var objCategoryList = _db.Categories.ToList();
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        //Get
        public IActionResult Create()
        {

            return View();
        }
    }
}
