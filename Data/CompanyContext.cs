using Microsoft.EntityFrameworkCore;
using CRM3.Models;

namespace CRM3.Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext (DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyDetails> CompanyDetails { get; set; }
    }
}   