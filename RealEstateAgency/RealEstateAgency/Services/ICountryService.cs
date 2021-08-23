using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public interface ICountryService : ICRUDService<Country, CountryInsertRequest, CountryInsertRequest, CountryInsertRequest>
    {
    }
}
