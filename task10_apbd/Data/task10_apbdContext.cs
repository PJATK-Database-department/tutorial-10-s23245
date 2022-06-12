using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using task10_apbd.Models;

namespace task10_apbd.Data
{
    public class task10_apbdContext : DbContext
    {
        public task10_apbdContext (DbContextOptions<task10_apbdContext> options)
            : base(options)
        {
        }

        public DbSet<task10_apbd.Models.Movie>? Movie { get; set; }
    }
}
