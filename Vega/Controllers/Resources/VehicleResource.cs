using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vega.Models;

namespace Vega.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public KeyValuePairResource Model { get; set; }

        public KeyValuePairResource Make { get; set; }
        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public DateTime LastUpdate { get; set; }

        //adding a new collection for using VehicleFeatures class to be able to make a bridge between vehicles and features
        public ICollection<KeyValuePairResource> Features { get; set; }

        //initializing the Vehicle const
        public VehicleResource()
        {
            Features = new Collection<KeyValuePairResource>();
        }
    }
}
