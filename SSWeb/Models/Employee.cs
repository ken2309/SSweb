using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSWeb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is not empty")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} is from 6-20 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0}is from 6-20 characters")]
        public string Password { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [RegularExpression("0\\d{9}", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        public string Qualification { get; set; }

        public string Department { get; set; }

        public bool IsAdmin { get; set; }

        public string Grade { get; set; }

        public bool Status { get; set; }
    }
}
