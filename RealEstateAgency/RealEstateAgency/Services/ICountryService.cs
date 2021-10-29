using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;

namespace RealEstateAgency.Services
{
    public interface ICountryService : ICRUDService<Country, CountryInsertRequest, CountryInsertRequest, CountryInsertRequest>
    {
    }
}