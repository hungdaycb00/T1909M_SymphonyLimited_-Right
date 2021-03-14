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
        public string Name { get; set; }
        public string StudentId { get; set; }
        public ICollection<Student> Students { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndTime { get; set; }

        public FeeStatus FeeStatus { get; set; }
    }
}