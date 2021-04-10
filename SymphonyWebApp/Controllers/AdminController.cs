using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SymphonyWebApp.Data;
using SymphonyWebApp.Data.Entities;
using SymphonyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Teachers = _context.Teacher.ToList();
            ClassStudies = _context.ClassStudies.ToList();
            Courses = _context.Courses.ToList();
            Students = _context.Students.ToList();

            ViewData["Teachers"] = Teachers;
            ViewData["ClassStudies"] = ClassStudies;
            ViewData["Courses"] = Courses;
            ViewData["Students"] = Students;

            return View();
        }
        public void OnGet()
        {
            
        }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<ClassStudy> ClassStudies { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
}
