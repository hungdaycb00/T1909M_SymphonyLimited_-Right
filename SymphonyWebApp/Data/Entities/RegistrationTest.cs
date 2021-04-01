using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class RegistrationTest
    {
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Registration Fee")]
        public decimal RegistrationFee { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

    public class ClassRegistrationTestValidator : AbstractValidator<RegistrationTest>
    {
        public ClassRegistrationTestValidator()
        {
            RuleFor(x => x.CourseName).NotNull();
            RuleFor(x => x.RegistrationFee).ScalePrecision(0, 4);
            RuleFor(x => x.CustomerId).NotNull();
        }
    }
}