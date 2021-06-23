using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSWeb.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public string Address { get; set; }

        [RegularExpression("0\\d{9}", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        public float Total { get; set; }

        public bool Status { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
