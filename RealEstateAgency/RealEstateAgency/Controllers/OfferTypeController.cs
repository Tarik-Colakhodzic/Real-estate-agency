using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class OfferTypeController : BaseReadController<Model.OfferType, object>
    {
        public OfferTypeController(IOfferTypeService service)
            : base(service)
        {
        }
    }
}