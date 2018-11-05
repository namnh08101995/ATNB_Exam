using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class Airport
    {
        //ID, a name, runway size, max fixed wing parking place, 
        //list of fixed wing airplane ID, max rotated wing parking place, list of helicopter ID.
        [Key]
        [StringLength(7)]
        public string AirportId { get; set; }

        [Required]
        [StringLength(255)]
        public string AirportName { get; set; }
        
        public double? RunwaySize { get; set; }
        
        public double? MaxFWParkingPlace { get; set; }

        public ICollection<Airplane> Airplanes { get; set; }

        public ICollection<Helicopter> Helicopters { get; set; }
    }
}
