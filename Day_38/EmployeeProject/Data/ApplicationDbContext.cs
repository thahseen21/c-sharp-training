using Microsoft.EntityFrameworkCore;
using EmployeeProject.Models.Implementation;

namespace EmployeeProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }
    }
}