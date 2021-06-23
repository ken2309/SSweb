using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSWeb.Models
{
    public class Customer
    {
        [Key]

        //test branch

        public int Id { get; set; }
     
        [Required(ErrorMessage = "{0} is not empty")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} is from 6-20 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0}is from 6-20 characters")]
        public string Password { get; set; }

        public string Fullname { get; set; }

        public bool Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [RegularExpression("0\\d{9}", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

        public List<Invoice> Invoices { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
