using Linkanized.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Linkanized.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ResourcesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> All()
        {
            var resources = await _db.Resources.ToListAsync();
            return View("List", resources);
        }

        public async Task<IActionResult> List(int id)
        {
            var resources = await _db.Resources.Where(r => r.SubCategoryId == id).ToListAsync();
            return View(resources);
        }
    }
}