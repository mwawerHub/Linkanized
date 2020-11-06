using Linkanized.Data;
using Linkanized.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Linkanized.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SubCategoryModel Category { get; set; }

        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> ListPanel(int id)
        {
            var categories = await _db.SubCategories
                .Where(c => c.MainCategoryId == id)
                .Include(c => c.MainCategory)
                .ToListAsync();

            return View(categories);
        }

        public IActionResult Create()
        {
            Category = new SubCategoryModel();
            return View(Category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save()
        {
            if (false == ModelState.IsValid)
                return View(Category);

            _db.SubCategories.Add(Category);
            _db.SaveChanges();

            return RedirectToAction("ListPanel");
        }
    }
}