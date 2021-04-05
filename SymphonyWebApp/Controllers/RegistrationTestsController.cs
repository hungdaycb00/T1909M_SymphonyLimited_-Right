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
    public class RegistrationTestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrationTestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegistrationTests
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RegistrationTests.Include(r => r.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RegistrationTests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationTest = await _context.RegistrationTests
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrationTest == null)
            {
                return NotFound();
            }

            return View(registrationTest);
        }

        // GET: RegistrationTests/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Contents");
            return View();
        }

        // POST: RegistrationTests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseName,RegistrationFee,CustomerId")] RegistrationTest registrationTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrationTest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Contents", registrationTest.CustomerId);
            return View(registrationTest);
        }

        // GET: RegistrationTests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationTest = await _context.RegistrationTests.FindAsync(id);
            if (registrationTest == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Contents", registrationTest.CustomerId);
            return View(registrationTest);
        }

        // POST: RegistrationTests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseName,RegistrationFee,CustomerId")] RegistrationTest registrationTest)
        {
            if (id != registrationTest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrationTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationTestExists(registrationTest.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Contents", registrationTest.CustomerId);
            return View(registrationTest);
        }

        // GET: RegistrationTests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationTest = await _context.RegistrationTests
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrationTest == null)
            {
                return NotFound();
            }

            return View(registrationTest);
        }

        // POST: RegistrationTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrationTest = await _context.RegistrationTests.FindAsync(id);
            _context.RegistrationTests.Remove(registrationTest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationTestExists(int id)
        {
            return _context.RegistrationTests.Any(e => e.Id == id);
        }
    }
}