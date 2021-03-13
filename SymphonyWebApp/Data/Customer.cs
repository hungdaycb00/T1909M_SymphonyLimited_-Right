using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Gmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Contents { get; set; }
    }
}