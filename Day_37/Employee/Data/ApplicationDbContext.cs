using Microsoft.EntityFrameworkCore;
using Employee.Models;
namespace Employee.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) :
            base(options)
        {
        }

        public DbSet<EmployeeModel> Customers { get; set; }
    }
}
