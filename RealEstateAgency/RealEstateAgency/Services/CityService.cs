using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class CityService : BaseReadService<Model.City, Database.City, object>, ICityService
    {
        public CityService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}