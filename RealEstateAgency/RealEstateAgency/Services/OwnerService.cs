using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class OwnerService : BaseCRUDService<Model.Owner, Owner, Model.SimpleSearchRequest, Model.Owner, Model.Owner>, IOwnerService
    {
        public OwnerService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}