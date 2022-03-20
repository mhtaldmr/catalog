using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public bool IsRegistered { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [Required]
        public string ContactPhone { get; set; }

        public DateTime LastUpdate { get; set; }

        //adding a new collection for using VehicleFeatures class to be able to make a bridge between vehicles and features
        public ICollection<VehicleFeature> Features { get; set; }

        //initializing the Vehicle const
        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
        }



    }
}
