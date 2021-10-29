using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class CountryController : BaseCRUDController<Country, CountryInsertRequest, CountryInsertRequest, CountryInsertRequest>
    {
        public CountryController(ICountryService service) : base(service)
        {
        }
    }
}