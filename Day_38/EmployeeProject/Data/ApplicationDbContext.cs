using Microsoft.EntityFrameworkCore;
using EmployeeProject.Models.Implementation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EmployeeProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }
    }
}