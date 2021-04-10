using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SymphonyWebApp.Data;
using SymphonyWebApp.Data.Entities;

namespace SymphonyWebApp.Controllers
{
    public class TestRoomsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestRoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TestRooms
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestRooms.ToListAsync());
        }

        // GET: TestRooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRoom = await _context.TestRooms.Include(x => x.Customers).Where(x => x.Id == id).ToListAsync();
            if (testRoom == null)
            {
                return NotFound();
            }
            TempData["TestRoomId"] = id;
            return View(testRoom);
        }

        // GET: TestRooms/Create
        public IActionResult Create()
        {
            return View();
        }
  


        // POST: TestRooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TestRoom testRoom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testRoom);
        }

        // GET: TestRooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRoom = await _context.TestRooms.FindAsync(id);
            if (testRoom == null)
            {
                return NotFound();
            }
            return View(testRoom);
        }

        // POST: TestRooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] TestRoom testRoom)
        {
            if (id != testRoom.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestRoomExists(testRoom.Id))
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
            return View(testRoom);
        }

        // GET: TestRooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testRoom = await _context.TestRooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testRoom == null)
            {
                return NotFound();
            }

            return View(testRoom);
        }

        // POST: TestRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testRoom = await _context.TestRooms.FindAsync(id);
            _context.TestRooms.Remove(testRoom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestRoomExists(int id)
        {
            return _context.TestRooms.Any(e => e.Id == id);
        }
    }
}
