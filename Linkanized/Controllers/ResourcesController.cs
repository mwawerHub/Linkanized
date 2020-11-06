﻿using Linkanized.Data;
using Linkanized.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Linkanized.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public ResourceModel Resource { get; set; }

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

        public IActionResult Create()
        {
            Resource = new ResourceModel();
            return View(Resource);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Resource = await _db.Resources.FirstOrDefaultAsync(r => r.Id == id);
            return View("Create", Resource);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save()
        {
            if (false == ModelState.IsValid)
                return View("Create");

            if (0 == Resource.Id)
                _db.Resources.Add(Resource);
            else
                _db.Resources.Update(Resource);

            _db.SaveChanges();
            return RedirectToAction("List", new { id = Resource.SubCategoryId });
        }
    }
}