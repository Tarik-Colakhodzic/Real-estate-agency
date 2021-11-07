using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class PropertyService : BaseCRUDService<Model.Property, Database.Property, Model.SimpleSearchRequest, Model.Property, Model.Property>, IPropertyService
    {
        public PropertyService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}