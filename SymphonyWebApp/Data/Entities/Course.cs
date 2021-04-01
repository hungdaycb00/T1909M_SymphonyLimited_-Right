using FluentValidation;
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

        [Display(Name = "Course Id")]
        public string CourseId { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fee { get; set; }

        public Level level { get; set; }
        public string UrlImage { get; set; }

        [Display(Name = "Training Time")]
        public int TrainingTime { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<ClassStudy> ClassStudies { get; set; }
    }

    public class ClassCourseValidator : AbstractValidator<Course>
    {
        public ClassCourseValidator()
        {
            RuleFor(x => x.CourseId).MinimumLength(3).MaximumLength(10).NotNull();
            RuleFor(x => x.CourseName).NotNull();
            RuleFor(x => x.Fee).NotNull().ScalePrecision(0, 4);
            RuleFor(x => x.level).NotNull();
            RuleFor(x => x.TrainingTime).NotNull();
        }
    }
}