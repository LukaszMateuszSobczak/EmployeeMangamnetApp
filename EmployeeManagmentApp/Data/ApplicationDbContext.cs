using EmployeeManagmentApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasOne(e => e.Address).WithOne(a => a.Employee).HasForeignKey<Address>(a => a.EmployeeId);

            var user1 = "13313a98-eeaa-4500-9f61-7ecb7953a12e";
            var user2 = "31c35515-0af5-4351-8061-cf16f84a9162";
            

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 4,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Pesel = "90010112345",
                    Email = "jan.kowalski@example.com",
                    Phone = "500600700",
                    Position = "Programista",
                    Salary = 8000m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user1
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Marek",
                    LastName = "Zieliński",
                    Pesel = "88050565432",
                    Email = "marek.zielinski@example.com",
                    Phone = "505404303",
                    Position = "Tester",
                    Salary = 6500m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user1
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Karolina",
                    LastName = "Lis",
                    Pesel = "95021287654",
                    Email = "karolina.lis@example.com",
                    Phone = "777888999",
                    Position = "Project Manager",
                    Salary = 11000m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user1
                },

                new Employee
                {
                    Id = 7,
                    FirstName = "Anna",
                    LastName = "Nowak",
                    Pesel = "92030554321",
                    Email = "anna.nowak@example.com",
                    Phone = "501501501",
                    Position = "HR Manager",
                    Salary = 9500m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user2
                },
                new Employee
                {
                    Id = 8,
                    FirstName = "Tomasz",
                    LastName = "Mazur",
                    Pesel = "87092311223",
                    Email = "tomasz.mazur@example.com",
                    Phone = "600700800",
                    Position = "DevOps Engineer",
                    Salary = 12000m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user2
                },
                new Employee
                {
                    Id = 9,
                    FirstName = "Natalia",
                    LastName = "Bąk",
                    Pesel = "98010199887",
                    Email = "natalia.bak@example.com",
                    Phone = "733444222",
                    Position = "UX Designer",
                    Salary = 9000m,
                    HireDate = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    UserId = user2
                }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 4, City = "Warszawa", StreetName = "Polna", HouseNumber = "12", ApartamentNumber = "3", PostalCode = "00-001", EmployeeId = 4 },
                new Address { Id = 5, City = "Łódź", StreetName = "Kwiatowa", HouseNumber = "8", ApartamentNumber = "2", PostalCode = "91-005", EmployeeId = 5 },
                new Address { Id = 6, City = "Gdańsk", StreetName = "Morska", HouseNumber = "5", ApartamentNumber = "10", PostalCode = "80-111", EmployeeId = 6 },

                new Address { Id = 7, City = "Kraków", StreetName = "Długa", HouseNumber = "5A", ApartamentNumber = "7", PostalCode = "31-002", EmployeeId = 7 },
                new Address { Id = 8, City = "Poznań", StreetName = "Lechicka", HouseNumber = "15", ApartamentNumber = "1", PostalCode = "60-101", EmployeeId = 8 },
                new Address { Id = 9, City = "Wrocław", StreetName = "Słoneczna", HouseNumber = "22", ApartamentNumber = "6", PostalCode = "50-500", EmployeeId = 9 }
            );
        }
    }
}
