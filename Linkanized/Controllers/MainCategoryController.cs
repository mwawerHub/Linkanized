using Linkanized.Data;
using Linkanized.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Linkanized.Controllers
{
    public class MainCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public MainCategoryModel Category { get; set; }

        public MainCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> ListPanel()
        {
            var categories = await _db.MainCategories.ToListAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            Category = new MainCategoryModel();
            return View(Category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save()
        {
            if (false == ModelState.IsValid)
                return View(Category);

            _db.MainCategories.Add(Category);
            _db.SaveChanges();

            return RedirectToAction("ListPanel");
        }
    }
}