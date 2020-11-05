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
            var newCategory = new MainCategoryModel();
            return View(newCategory);
        }
    }
}