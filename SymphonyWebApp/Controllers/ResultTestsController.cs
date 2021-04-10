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
    public class ResultTestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultTestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ResultTests
        public async Task<IActionResult> Index(string keyword)
        {
            if (keyword != null)
            {
                ViewBag.Keyword = keyword;
                var result = await _context.ResultTests.Where(x => x.FirstName.Contains(keyword) || x.ClassName.Contains(keyword) || x.LastName.Contains(keyword) || x.CourseName.Contains(keyword)).OrderByDescending(x => x.Id).ToListAsync();
                return View(result);
            }
            return View(await _context.ResultTests.OrderByDescending(x => x.Id).ToListAsync());
        }

        // GET: ResultTests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultTest = await _context.ResultTests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resultTest == null)
            {
                return NotFound();
            }

            return View(resultTest);
        }

        // GET: ResultTests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResultTests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RollNumber,FirstName,LastName,Gmail,Dob,ClassName,CourseName,Fee,SubFee,LastDayPayment")] ResultTest resultTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resultTest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resultTest);
        }

        // GET: ResultTests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultTest = await _context.ResultTests.FindAsync(id);
            if (resultTest == null)
            {
                return NotFound();
            }
            return View(resultTest);
        }

        // POST: ResultTests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RollNumber,FirstName,LastName,Gmail,Dob,ClassName,CourseName,Fee,SubFee,LastDayPayment")] ResultTest resultTest)
        {
            if (id != resultTest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resultTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResultTestExists(resultTest.Id))
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
            return View(resultTest);
        }

        // GET: ResultTests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultTest = await _context.ResultTests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resultTest == null)
            {
                return NotFound();
            }

            return View(resultTest);
        }

        // POST: ResultTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultTest = await _context.ResultTests.FindAsync(id);
            _context.ResultTests.Remove(resultTest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResultTestExists(int id)
        {
            return _context.ResultTests.Any(e => e.Id == id);
        }
    }
}