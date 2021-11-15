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
            CreateMap<Model.Agent, Database.Agent>().ReverseMap();
            CreateMap<Model.City, Database.City>().ReverseMap();
            CreateMap<Model.Country, Database.Country>().ReverseMap();
            CreateMap<Model.Owner, Database.Owner>().ReverseMap();
            CreateMap<Model.PropertyPhoto, Database.PropertyPhoto>().ReverseMap();
            CreateMap<Model.Property, Database.Property>().ReverseMap();
            CreateMap<Model.Category, Database.Category>().ReverseMap();
            CreateMap<Model.OfferType, Database.OfferType>().ReverseMap();
            CreateMap<Model.Contract, Database.Contract>().ReverseMap();
        }
    }
}