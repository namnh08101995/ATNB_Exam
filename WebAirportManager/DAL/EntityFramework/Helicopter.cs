﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class Helicopter
    {
        //ID, model, cruise speed, empty weight, max takeoff weight, range

        [Key]
        [StringLength(7)]
        public string HelicopterId { get; set; }

        [Required]
        [StringLength(40)]
        public string Model { get; set; }

        public double? CruiseSpeed { get; set; }

        public double? EmptyWeight { get; set; }

        public double? MaxTakeoffWeight { get; set; }

        public double? Range { get; set; }

        [ForeignKey("Airport")]
        public string AirportId { get; set; }

        public virtual Airport Airport { get; set; }
    }
}
