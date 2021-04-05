using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Examination
    {
        public int Id { get; set; }

        [Display(Name = "Course")]
        public string CourseId { get; set; }

        public string Note { get; set; }

        [Display(Name = "Test Fee")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fee { get; set; }

        [Display(Name = "Test Day")]
        [DataType(DataType.Date)]
        public DateTime TestDay { get; set; }
    }

    public class ExaminationValidator : AbstractValidator<Examination>
    {
        public ExaminationValidator()
        {
            RuleFor(x => x.CourseId).NotNull();
            RuleFor(x => x.Fee).NotNull().ScalePrecision(0, 4);
            RuleFor(x => x.TestDay).NotNull().GreaterThan(DateTime.Now);
        }
    }
}