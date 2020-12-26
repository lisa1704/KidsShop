using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KidsShop.Models;

namespace KidsShop.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "toys"
                    
                },
                new Category
                {
                    Id = 2,
                    Name = "cloths"
                    
                },
                new Category
                {
                    Id = 3,
                    Name = "diapers"
                    
                }
            );
        }

    }
}
