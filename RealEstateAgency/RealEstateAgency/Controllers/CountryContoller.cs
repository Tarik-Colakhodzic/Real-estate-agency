using RealEstateAgency.Controllers;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Controllers
{
    public class CountryController : BaseCRUDController<Country, CountryInsertRequest, CountryInsertRequest, CountryInsertRequest>
    {
        public CountryController(ICountryService service) : base(service)
        {
        }
    }
}