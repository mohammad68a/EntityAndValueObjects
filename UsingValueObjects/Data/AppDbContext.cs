using Microsoft.EntityFrameworkCore;
using System;
using UsingValueObjects.Data.Models;

namespace UsingValueObjects.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=ProductDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(x =>
            {
                x.HasKey(k => k.Id);
                x.OwnsOne(o => o.Price);
                x.Property(p => p.Id).ValueGeneratedOnAdd();
            });
        }
    }
}