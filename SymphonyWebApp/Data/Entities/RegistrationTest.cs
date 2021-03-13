using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class RegistrationTest
    {
        public int Id { get; set; }
        public decimal RegistrationFee { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}