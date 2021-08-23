using AutoMapper;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Mapping
{
    public class RealEstateAgencyProfile : Profile
    {
        public RealEstateAgencyProfile()
        {
            CreateMap<User, Model.User>().ReverseMap();
            CreateMap<Country, CountryInsertRequest>().ReverseMap();
        }
    }
}
