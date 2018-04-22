using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CartsMVC.Models
{
    public class CartsDataContext : DbContext
    {
        public CartsDataContext() 
            : base("Name=Default")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}