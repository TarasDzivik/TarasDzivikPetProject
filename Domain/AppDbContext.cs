using TarasDzivikPetProject.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TarasDzivikPetProject.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TestFields { get; set; }
        public DbSet<VehicleItem> VehicleItem { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
        }
    }
}