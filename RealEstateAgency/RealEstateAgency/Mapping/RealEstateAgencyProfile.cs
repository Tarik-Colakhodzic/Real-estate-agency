using AutoMapper;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;

namespace RealEstateAgency.Mapping
{
    public class RealEstateAgencyProfile : Profile
    {
        public RealEstateAgencyProfile()
        {
            CreateMap<User, Model.User>().ReverseMap();
            CreateMap<Country, CountryInsertRequest>().ReverseMap();
            CreateMap<Model.Requests.UserInsertRequest, Database.User>().ReverseMap();
            CreateMap<Model.Role, Database.Role>().ReverseMap();
            CreateMap<Model.UserRoles, Database.UserRoles>().ReverseMap();
        }
    }
}