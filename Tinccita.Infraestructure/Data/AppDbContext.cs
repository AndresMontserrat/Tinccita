using Microsoft.EntityFrameworkCore;
using Tinccita.Domain.Entities;

namespace Tinccita.Infraestructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<AppointmentAvailable> AppointmentsAvailable { get; set; }
        public DbSet<AppointmentBooked> AppointmentsBooked { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\BBDD\\Tinccita\\castello.db");
            }
        }
    }
}
