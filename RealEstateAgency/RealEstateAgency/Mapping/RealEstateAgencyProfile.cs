using AutoMapper;
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
            CreateMap<Database.User, Model.User>();
        }
    }
}
