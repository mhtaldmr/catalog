using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Vega.Controllers.Resources;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {
            public MappingProfile()
        {
            //Domain to API Recource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, KeyValuePairResource>();
            CreateMap<Feature, KeyValuePairResource>();
            CreateMap<Vehicle, SaveVehicleResource>()
                .ForMember(vr => vr.Contact, op => op.MapFrom(v => new ContactResource { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
                .ForMember(vr => vr.Features, op => op.MapFrom(v => v.Features.Select(vf => vf.FeatureId )));

            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Make, op => op.MapFrom(v => v.Model.Make))
                .ForMember(vr => vr.Contact, op => op.MapFrom(v => new ContactResource { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
                .ForMember(vr => vr.Features, op => op.MapFrom(v => v.Features.Select(vf => new KeyValuePairResource { Id = vf.Feature.Id, Name= vf.Feature.Name })));


            //API resource to Domain
            CreateMap<SaveVehicleResource, Vehicle>()
                //.ForMember(v => v.Id, op => op.Ignore())
                .ForMember(v => v.ContactName, op => op.MapFrom(vr => vr.Contact.Name))
                .ForMember(v => v.ContactEmail, op => op.MapFrom(vr => vr.Contact.Email))
                .ForMember(v => v.ContactPhone, op => op.MapFrom(vr => vr.Contact.Phone))
                .ForMember(v => v.Features, op => op.MapFrom(vr => vr.Features.Select(id => new VehicleFeature { FeatureId = id }))); //.Ignore())
                //.AfterMap((vr, v) =>
                //{
                //    //Remove unselected features
                //    var removedFeatures = new List<VehicleFeature>();
                //    foreach (var f in v.Features)
                //        if (!vr.Features.Contains(f.FeatureId))
                //            removedFeatures.Add(f);
                //    foreach (var id in removedFeatures)
                //        v.Features.Remove(id);

            //    //Adding selected features
            //    foreach (var id in vr.Features)
            //        if (v.Features.Any(f => f.FeatureId == id))
            //            v.Features.Add(new VehicleFeature { FeatureId = id });

            //});
        }

    }
}
