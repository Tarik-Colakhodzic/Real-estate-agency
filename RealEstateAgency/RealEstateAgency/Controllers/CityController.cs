using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class CityController : BaseReadController<Model.City, object>
    {
        public CityController(ICityService service)
            : base(service)
        {
        }
    }
}