using Microsoft.EntityFrameworkCore;
using NewConnectingDb.Models;

namespace NewConnectingDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) :
            base(options)
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
