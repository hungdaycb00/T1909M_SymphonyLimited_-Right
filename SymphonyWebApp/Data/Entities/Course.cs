using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fee { get; set; }

        public Level level { get; set; }

        [DataType(DataType.Date)]
        public DateTime TrainingTime { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<ClassStudy> ClassStudies { get; set; }
    }
}