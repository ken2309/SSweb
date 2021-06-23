using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
      
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public string Image { get; set; }
        public bool IsService { get; set; }
        public bool Status { get; set; }
        public List<Image> Images { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
