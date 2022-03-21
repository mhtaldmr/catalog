using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vega.Models;

namespace Vega.Controllers.Resources

{
    public class VehicleResource
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }

        //adding a new collection for using VehicleFeatures class to be able to make a bridge between vehiclesRecource and features
        public ICollection<int> Features { get; set; }

        //initializing the VehicleResource const
        public VehicleResource()
        {
            Features = new Collection<int>();
        }
       

    }
}
