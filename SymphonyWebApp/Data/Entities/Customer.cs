using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Gmail { get; set; }



        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Contents { get; set; }

        public RegistrationTest RegistrationTest { get; set; }
    }
    public class ClassCustomerValidator : AbstractValidator<Customer>
    {
        public ClassCustomerValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Gmail).NotNull().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Contents).Null();
        }

    }
}