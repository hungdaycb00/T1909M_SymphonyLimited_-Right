using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class StudentDetail
    {
        public int Id { get; set; }
        public int ClassId { get; set; }

        public string RollNumber { get; set; }
        public Student Students { get; set; }
        public int CourseId { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Level Level { get; set; }

        public decimal SubFee { get; set; }
        public StudentStatus StudentStatus { get; set; }
    }
}