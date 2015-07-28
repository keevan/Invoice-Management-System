using IMS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL.Data {
    public class DataContext : DbContext {

        public DataContext() 
            : base("DefaultConnection") {

        }

        /*
            Add Models here so the Entity framework knows which models to use
         */
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
}
