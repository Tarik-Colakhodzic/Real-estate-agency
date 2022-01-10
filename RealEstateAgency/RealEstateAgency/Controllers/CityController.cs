using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class CityController : BaseReadController<Model.City, Model.Requests.CountrySearchRequest>
    {
        public CityController(ICityService service)
            : base(service)
        {
        }
    }
}