using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM3.Data
{
    public class CRM3LoginContext : IdentityDbContext
    {
        public CRM3LoginContext(DbContextOptions<CRM3LoginContext> options)
            : base(options)
        {
        }
    }
}