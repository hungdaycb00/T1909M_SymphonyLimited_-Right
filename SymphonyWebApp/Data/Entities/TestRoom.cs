using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class TestRoom
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
    public class TestRoomValidator : AbstractValidator<TestRoom>
    {
        public TestRoomValidator()
        {

            RuleFor(x => x.Name).NotNull();
           
        }
    }
}
