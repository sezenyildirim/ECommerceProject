using ECommerce.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Context
{
    public class eCommerceDBContext : IdentityDbContext<AppUser, AppRole,string>
    {
     //entity configuration
        public eCommerceDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<Option> Options { get; set; }    
        public DbSet<Discount> Discounts { get; set; }    
        public DbSet<Comment> Comments { get; set; }    
        public DbSet<Payment> Payments { get; set; }    
        public DbSet<Order> Orders { get; set; }    
        public DbSet<Basket> Baskets { get; set; }    
    }
}
