using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class Airplane
    {
        //ID, model, plane type, cruise speed, empty weight, max takeoff weight, min needed runway size

        [Key]
        [StringLength(7)]
        public string AirplaneId { get; set; }

        [Required]
        [StringLength(255)]
        public string Model { get; set; }

        [Required]
        [StringLength(255)]
        public string PlaneType { get; set; }
        
        public double? CruiseSpeed { get; set; }
        
        public double? EmptyWeight { get; set; }
        
        public double? MaxTakeoffWeight { get; set; }

        public double? MinNeededRunwaySize { get; set; }

        [ForeignKey("Airport")]
        public string AirportId { get; set; }

        public virtual Airport Airport { get; set; }
    }
}
