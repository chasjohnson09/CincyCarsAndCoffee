using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincyCarsAndCoffee.Data
{
    class CACDbContext : DbContext
    {
        public CACDbContext (DbContextOptions<CACDbContext> options)
            : base(options)
        {
        }
        public DbSet<CincyCarsAndCoffee.Models.North> North { get; set; }
        public DbSet<CincyCarsAndCoffee.Models.North> East { get; set; }
        public DbSet<CincyCarsAndCoffee.Models.North> South { get; set; }
        public DbSet<CincyCarsAndCoffee.Models.North> West { get; set; }

    }
}
