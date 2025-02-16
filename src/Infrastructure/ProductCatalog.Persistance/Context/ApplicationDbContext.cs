using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Persistance.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Name1",},
                new Product() { Id = 2, Name = "Name2",},
                new Product() { Id = 3, Name = "Name3",}

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
