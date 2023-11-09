using PPM.Model; // Import the System namespace for basic .NET functionality.
using Microsoft.EntityFrameworkCore; // Import the Entity Framework Core namespace for database operations.


namespace PPM.Domain
{
    public class DbContextFile : DbContext // Define a class named DbContextFile that inherits from DbContext.
    {
        ConnectionString connectionString = new();
        public DbSet<Project> Projects { get; set; } // Define a DbSet property for the Project entity.
        public DbSet<Employee> Employees { get; set; } // Define a DbSet property for the Employee entity.
        public DbSet<Role> Roles { get; set; } // Define a DbSet property for the Role entity.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connectionString.Connection());
           // Configure the database connection to use SQL Server with a specific connection string.
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Project>(entity =>
        //     {
        //         entity.ToTable("Projects");
        //         entity.HasKey(e => e.ProjectId);
        //         entity.Property(e => e.ProjectId).ValueGeneratedOnAdd().IsRequired();
        //         entity.Property(e => e.ProjectName).IsRequired();
        //         entity.Property(e => e.ProjectStartDate).IsRequired();
        //         entity.Property(e => e.ProjectEndDate).IsRequired();
        //     });

        //     modelBuilder.Entity<Employee>(entity =>
        //     {
        //         entity.ToTable("Employees");
        //         entity.HasKey(e => e.EmployeeId);
        //         entity.Property(e => e.EmployeeId).ValueGeneratedOnAdd().IsRequired();
        //         entity.Property(e => e.EmployeeFirstName).IsRequired();
        //         entity.Property(e => e.EmployeeLastName).IsRequired();
        //         entity.Property(e => e.EmployeeMobileNumber).IsRequired();
        //         entity.Property(e => e.EmployeeAddress).IsRequired();
        //         entity.Property(e => e.EmployeeRoleId).IsRequired();
        //     });

        //     modelBuilder.Entity<Role>(entity =>
        //     {
        //         entity.ToTable("Roles");
        //         entity.HasKey(e => e.RoleId);
        //         entity.Property(e => e.RoleId).ValueGeneratedOnAdd().IsRequired();
        //         entity.Property(e => e.RoleName).IsRequired();
        //     });
        // }
    }
}
