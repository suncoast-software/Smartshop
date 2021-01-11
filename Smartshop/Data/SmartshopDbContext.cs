using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Smartshop.Models;

namespace Smartshop.Data
{
    public class SmartshopDbContext : DbContext
    {
        public IConfiguration _configuration { get; set; }

        public SmartshopDbContext() { }

        //Add DbSet<Class> here
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=smartshopDB;User Id=postgres;Password=451145_Gl;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>().HasKey(m => m.Id);
            modelBuilder.Entity<Customer>().HasKey(m => m.Id);
        }
    }
}
