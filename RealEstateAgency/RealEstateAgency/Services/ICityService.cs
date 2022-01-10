using RealEstateAgency.Model;

namespace RealEstateAgency.Services
{
    public interface ICityService : IReadService<City, Model.Requests.CountrySearchRequest>
    {
    }
}