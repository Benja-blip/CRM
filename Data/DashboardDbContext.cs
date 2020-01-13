using Microsoft.EntityFrameworkCore;
using CRM3.Models;

namespace CRM3.Data
{
    public class DashboardContext : DbContext
    {
        public DashboardContext (DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}   