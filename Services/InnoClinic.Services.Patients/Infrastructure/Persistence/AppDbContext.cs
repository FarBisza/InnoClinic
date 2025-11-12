using Microsoft.EntityFrameworkCore;
using InnoClinic.Services.Patients.Domain.Entities;
using InnoClinic.Services.Patients.Application.DTO;

namespace InnoClinic.Services.Patients.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, FirstName = "Van", MiddleName = "Dark", LastName = "Holm", DateOfBirth = new DateTime(1900, 12, 5), IsLinkedToAccount = true, AccountId = 1 },
                new Patient { Id = 2, FirstName = "John", MiddleName = "Doe", LastName = "Smith", DateOfBirth = new DateTime(1985, 3, 15), IsLinkedToAccount = true, AccountId = 2 },
                new Patient { Id = 3, FirstName = "Jane", MiddleName = "A", LastName = "Doe", DateOfBirth = new DateTime(1992, 7, 20), IsLinkedToAccount = false, AccountId = 3 },
                new Patient { Id = 4, FirstName = "Alice", MiddleName = "B", LastName = "Johnson", DateOfBirth = new DateTime(1978, 11, 30), IsLinkedToAccount = true, AccountId = 4 },
                new Patient { Id = 5, FirstName = "Bob", MiddleName = "C", LastName = "Williams", DateOfBirth = new DateTime(1982, 6, 5), IsLinkedToAccount = true, AccountId = 5 },
                new Patient { Id = 6, FirstName = "Charlie", MiddleName = "D", LastName = "Brown", DateOfBirth = new DateTime(1990, 8, 22), IsLinkedToAccount = false, AccountId = 6 },
                new Patient { Id = 7, FirstName = "David", MiddleName = "E", LastName = "Miller", DateOfBirth = new DateTime(1995, 2, 10), IsLinkedToAccount = true, AccountId = 7 },
                new Patient { Id = 8, FirstName = "Eva", MiddleName = "F", LastName = "Davis", DateOfBirth = new DateTime(1988, 5, 30), IsLinkedToAccount = false, AccountId = 8 },
                new Patient { Id = 9, FirstName = "Frank", MiddleName = "G", LastName = "Martinez", DateOfBirth = new DateTime(1993, 9, 25), IsLinkedToAccount = true, AccountId = 9 },
                new Patient { Id = 10, FirstName = "Grace", MiddleName = "H", LastName = "Garcia", DateOfBirth = new DateTime(1980, 4, 17), IsLinkedToAccount = true, AccountId = 10 }
            );
        }
        
    
    }
}