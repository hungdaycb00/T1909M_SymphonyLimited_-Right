using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class ResultTest
    {
        public int Id { get; set; }

        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [EmailAddress]
        public string Gmail { get; set; }

        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Fee { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Sub Fee")]
        public decimal SubFee { get; set; }

        [Display(Name = "Last day of payment")]
        [DataType(DataType.Date)]
        public DateTime LastDayPayment { get; set; }
    }

    public class ResultTestValidator : AbstractValidator<ResultTest>
    {
        public ResultTestValidator()
        {
            RuleFor(x => x.RollNumber).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.CourseName).NotNull();
            RuleFor(x => x.ClassName).NotNull();
            RuleFor(x => x.Gmail).NotEmpty().EmailAddress();
            RuleFor(x => x.LastDayPayment).GreaterThan(DateTime.Now);
        }
    }
}