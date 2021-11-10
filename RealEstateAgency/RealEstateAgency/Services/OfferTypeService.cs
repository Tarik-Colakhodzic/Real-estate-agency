using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class OfferTypeService : BaseReadService<Model.OfferType, Database.OfferType, object>, IOfferTypeService
    {
        public OfferTypeService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}