using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SymphonyWebApp.Data;
using SymphonyWebApp.Data.Entities;

namespace SymphonyWebApp.Controllers
{
    [Authorize]
    public class ClassStudiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassStudiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClassStudies
        public async Task<IActionResult> Index(string keyword)
        {
            if (keyword != null)
            {
                ViewBag.Keyword = keyword;
                var result = await _context.ClassStudies.Where(x => x.ClassId.Contains(keyword)
                || x.Name.Contains(keyword)).ToListAsync();
                return View(result);
            }
            return View(await _context.ClassStudies.ToListAsync());
        }

        // GET: ClassStudies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classStudy = await _context.ClassStudies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classStudy == null)
            {
                return NotFound();
            }

            return View(classStudy);
        }

        // GET: ClassStudies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassStudies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassId,Name,StartTime,EndTime")] ClassStudy classStudy)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", classStudy);
            }

            _context.Add(classStudy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View(classStudy);
        }

        // GET: ClassStudies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classStudy = await _context.ClassStudies.FindAsync(id);
            if (classStudy == null)
            {
                return NotFound();
            }
            return View(classStudy);
        }

        // POST: ClassStudies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassId,Name,StartTime,EndTime")] ClassStudy classStudy)
        {
            if (id != classStudy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classStudy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassStudyExists(classStudy.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(classStudy);
        }

        // GET: ClassStudies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classStudy = await _context.ClassStudies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classStudy == null)
            {
                return NotFound();
            }

            return View(classStudy);
        }

        // POST: ClassStudies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classStudy = await _context.ClassStudies.FindAsync(id);
            _context.ClassStudies.Remove(classStudy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassStudyExists(int id)
        {
            return _context.ClassStudies.Any(e => e.Id == id);
        }
    }
}