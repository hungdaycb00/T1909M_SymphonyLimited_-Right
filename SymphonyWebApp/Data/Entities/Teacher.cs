using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Gmail { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        public string Address { get; set; }

        [Display(Name = "Avatar")]
        public string UrlImage { get; set; }

        public string Major { get; set; }
    }

    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.Major).NotNull();
            RuleFor(x => x.Dob).LessThan(DateTime.Now.AddYears(10));
            RuleFor(x => x.Gmail).EmailAddress();
        }
    }
}