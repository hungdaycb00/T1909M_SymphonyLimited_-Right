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
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [EmailAddress]
        public string Gmail { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Display(Name = "Identity Card")]
        public string IdentityCard { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Sub Fee")]
        public decimal SubFee { get; set; }

        [Display(Name = "Fee Status")]
        public FeeStatus FeeStatus { get; set; }

        [Display(Name = "Student Status")]
        public StudentStatus StudentStatus { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ClassId { get; set; }
        public ClassStudy ClassStudy { get; set; }
    }

    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.RollNumber).NotNull().MinimumLength(5).MaximumLength(10);
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.Gmail).NotEmpty().EmailAddress();
            RuleFor(x => x.Dob).NotNull().LessThan(DateTime.Now.AddYears(-12));
            RuleFor(x => x.IdentityCard).MaximumLength(20);
            RuleFor(x => x.PhoneNumber).NotNull();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.SubFee).GreaterThanOrEqualTo(0);
            RuleFor(x => x.FeeStatus).NotNull();
            RuleFor(x => x.CourseId).NotNull();
            RuleFor(x => x.ClassId).NotNull();
        }
    }
}