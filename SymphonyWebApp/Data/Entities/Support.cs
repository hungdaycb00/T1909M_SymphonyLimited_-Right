using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Support
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Question { get; set; }
    }
}