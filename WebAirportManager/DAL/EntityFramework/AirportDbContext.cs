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
        public AirportDbContext() : base("name=AirportDBConnectionString")
        {
            Database.SetInitializer<AirportDbContext>(new DropCreateDatabaseAlways<AirportDbContext>());

            //Database.SetInitializer<AirportDbContext>(new DropCreateDatabaseIfModelChanges<AirportDbContext>());
            //Database.SetInitializer<AirportDbContext>(new SchoolDBInitializer());
            //Database.SetInitializer<AirportDbContext>(new CreateDatabaseIfNotExists<AirportDbContext>());
        }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airplane> AirPlanes { get; set; }
        public DbSet<Helicopter> Helicopters { get; set; }
    }
}
