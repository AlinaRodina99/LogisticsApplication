using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LogisticsApplication.Models;

namespace LogisticsApplication.Data
{
    public class LogisticsApplicationContext : DbContext
    {
        public LogisticsApplicationContext (DbContextOptions<LogisticsApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<LogisticsApplication.Models.Order> Order { get; set; } = default!;
    }
}
