using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Centre
    {
        public int Id { get; set; }
        public string Address { get; set; }

    }
    public class ClassCentreValidator : AbstractValidator<Centre>
    {
        public ClassCentreValidator()
        {
            RuleFor(x => x.Address).NotNull();
        }
    }
}
