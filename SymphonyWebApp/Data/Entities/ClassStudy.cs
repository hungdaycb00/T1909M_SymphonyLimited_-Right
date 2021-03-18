using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class ClassStudy
    {
        public int Id { get; set; }
        [Display(Name = "Class Id")]
        public string ClassId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }


        [Display(Name = "End Time")]
        [DataType(DataType.Date)]
        public DateTime EndTime { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}