using FluentValidation;
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

    public class ClassStudyValidator : AbstractValidator<ClassStudy>
    {
        public ClassStudyValidator()
        {
            DateTime dateNow = DateTime.Now;
            RuleFor(x => x.ClassId).MinimumLength(5).MaximumLength(10).NotNull();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.StartTime).GreaterThan(dateNow).WithMessage("Start Time must be greater than now");
            RuleFor(x => x.EndTime).GreaterThan(d => d.StartTime.AddMonths(4)).WithMessage("End Time must be greater than the start time of 4 months");
        }
    }
}