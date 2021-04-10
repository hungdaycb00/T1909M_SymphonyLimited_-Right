using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Models
{
    public class ViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<ClassStudy> ClassStudies { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
