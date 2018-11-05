using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class AirportDbContext: DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airplane> AirPlanes { get; set; }
        public DbSet<Helicopter> Helicopters { get; set; }
    }
}
