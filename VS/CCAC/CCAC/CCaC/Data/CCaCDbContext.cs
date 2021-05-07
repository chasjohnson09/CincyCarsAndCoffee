using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCaC.Models;

namespace CCaC.Data
{
    public class CCaCDbContext : DbContext
    {
        public CCaCDbContext(DbContextOptions<CCaCDbContext> options)
            : base(options)
        {
        }
        public DbSet<CCaC.Models.North> North { get; set; }
        public DbSet<CCaC.Models.North> East { get; set; }
        public DbSet<CCaC.Models.North> South { get; set; }
        public DbSet<CCaC.Models.North> West { get; set; }
        public DbSet<CCaC.Models.Downtown> Downtown { get; set; }
        public DbSet<CCaC.Models.East> East_1 { get; set; }
        public DbSet<CCaC.Models.South> South_1 { get; set; }
        public DbSet<CCaC.Models.West> West_1 { get; set; }
    }
}
