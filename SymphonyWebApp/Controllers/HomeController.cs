using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SymphonyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SymphonyWebApp.Data;
using SymphonyWebApp.Data.Entities;
using System.Dynamic;

namespace SymphonyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.Take(6).ToListAsync());
        }

        public IEnumerable<Teacher> Teachers { get; set; }

        public async Task<IActionResult> About()
        {
            var about = await _context.Posts.Where(x => x.Id == 1).ToListAsync();
            Teachers = _context.Teacher.Take(4).ToList();

            ViewData["Teacher"] = Teachers;

            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer(string name, string gmail, string phonenumber, string content)
        {
            var customer = new Customer();
            customer.Name = name;
            customer.Gmail = gmail;
            customer.PhoneNumber = phonenumber;
            customer.Contents = content;
            customer.CreatingDate = DateTime.Now;
            _context.Add(customer);
            await _context.SaveChangesAsync();
            TempData["msg"] = "Submitted successfully!";
            TempData["msg1"] = "We will contact you by mail or phone number.";
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Course(string courseId, int? id)
        {
            if (courseId != null)
            {
                ViewBag.Keyword = courseId;
                var result = await _context.Courses.Where(x => x.CourseId == courseId).ToListAsync();
                return View(result);
            }

            return View(await _context.Courses.ToListAsync());
        }

        public async Task<IActionResult> CourseDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        public async Task<IActionResult> FAQ()
        {
            return View(await _context.Questions.ToListAsync());
        }

        public async Task<IActionResult> Entrance()
        {
            return View(await _context.Examinations.ToListAsync());
        }

        public async Task<IActionResult> Contact()
        {
            return View(await _context.Centres.ToListAsync());
        }

        public async Task<IActionResult> Instructor()
        {
            return View(await _context.Teacher.ToListAsync());
        }

        public async Task<IActionResult> FinalResult(string keyword)
        {
            if (keyword != null)
            {
                ViewBag.Keyword = keyword;
                var result = await _context.ResultTests.Where(x => x.RollNumber.Contains(keyword)).ToListAsync();
                return View(result);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}