using AutoMapper;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class CountryService : BaseCRUDService<Country, Country, CountryInsertRequest, CountryInsertRequest, CountryInsertRequest>, ICountryService
    {
        public CountryService(RealEstateAgencyContext context, IMapper mapper)
                : base(context, mapper)
        {
        }

        public override IEnumerable<Country> Get(CountryInsertRequest search = null)
        {
            var entity = Context.Set<Country>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                entity = entity.Where(x => x.Name.Contains(search.Name));
            }

            var list = entity.ToList();

            return list;
        }
    }
}