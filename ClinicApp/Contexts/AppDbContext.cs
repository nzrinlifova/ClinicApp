using ClinicApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Contexts
{
    public class AppDbContext:DbContext
    {
        private readonly string _connectionString = @"Server=NEZRINUS\SQLEXPRESS;Database=KlinikAppDb;Trusted_Connection=True;TrustServerCertificate=True;";
        public DbSet<Doctor> doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
