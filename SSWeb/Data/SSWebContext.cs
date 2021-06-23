using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace SSWeb.Data
{
    public class SSWebContext : DbContext
    {
        public SSWebContext(DbContextOptions<SSWebContext> options) : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
