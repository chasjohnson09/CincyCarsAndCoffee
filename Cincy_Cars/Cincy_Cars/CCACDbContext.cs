using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cincy_Cars
{
    public class CCACDbContext : DbContext
    {
        public CCACDbContext(DbContextOptions<CCACDbContext> options)
               : base(options)
        {
        }

        public DbSet<Cincy_Cars.Models.Downtown> Dowtown { get; set; }
        public DbSet<Cincy_Cars.Models.North> North { get; set; }
        public DbSet<Cincy_Cars.Models.South> South { get; set; }
        public DbSet<Cincy_Cars.Models.East> East { get; set; }
        public DbSet<Cincy_Cars.Models.West> West { get; set; }
    }
}
