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
        public string RollNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gmail { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        public string IdentityCard { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubFee { get; set; }

        public FeeStatus FeeStatus { get; set; }
        public StudentStatus StudentStatus { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ClassId { get; set; }
        public ClassStudy ClassStudy { get; set; }
    }
}