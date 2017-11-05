using System.Collections.Generic;
using System.Data.Entity;
namespace Chap7
{
    public class SolarSystemContext : DbContext
    {
        public DbSet<Moon> Moons { get; set; }
        public DbSet<Planet> Planets { get; set; }
    }
}