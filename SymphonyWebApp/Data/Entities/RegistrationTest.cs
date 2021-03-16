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
        public string CourseName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RegistrationFee { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}