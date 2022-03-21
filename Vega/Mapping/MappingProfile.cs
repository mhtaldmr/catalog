using AutoMapper;
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
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();

            //API resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(v => v.ContactName, op => op.MapFrom(vr => vr.Contact.Name))
                .ForMember(v => v.ContactEmail, op => op.MapFrom(vr => vr.Contact.Email))
                .ForMember(v => v.ContactPhone, op => op.MapFrom(vr => vr.Contact.Phone))
                .ForMember(v => v.Features, op => op.MapFrom(vf => vf.Features.Select(id => new VehicleFeature { FeatureId = id })));


        }

    }
}
