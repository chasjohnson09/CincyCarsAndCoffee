using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Init_Project.Data
{
    public class CCACDbContext : DbContext
    {
        public CCACDbContext(DbContextOptions<CCACDbContext> options)
       : base(options)
        {
        }
        public DbSet<Init_Project.Models.North> North { get; set; }
        public DbSet<Init_Project.Models.East> East { get; set; }
        public DbSet<Init_Project.Models.South> South { get; set; }
        public DbSet<Init_Project.Models.West> West { get; set; }
        public DbSet<Init_Project.Models.Downtown> Downtown { get; set; }
    }
}
