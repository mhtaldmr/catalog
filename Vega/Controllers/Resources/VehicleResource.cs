using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vega.Models;

namespace Vega.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public ModelResource Model { get; set; }

        public MakeResource Make { get; set; }
        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public DateTime LastUpdate { get; set; }

        //adding a new collection for using VehicleFeatures class to be able to make a bridge between vehicles and features
        public ICollection<FeatureResource> Features { get; set; }

        //initializing the Vehicle const
        public VehicleResource()
        {
            Features = new Collection<FeatureResource>();
        }
    }
}
