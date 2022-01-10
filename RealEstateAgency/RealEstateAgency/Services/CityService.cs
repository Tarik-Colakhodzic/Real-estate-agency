using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class CityService : BaseReadService<Model.City, Database.City, Model.Requests.CountrySearchRequest>, ICityService
    {
        public CityService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IEnumerable<Model.City> Get(CountrySearchRequest search = null)
        {
            var entity = Context.Set<Database.City>().AsQueryable();
            if (search != null)
            {
                if (search.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
                if (search.CountryId.HasValue)
                {
                    entity = entity.Where(x => x.CountryId == search.CountryId);
                }
            }
            var list = entity.ToList();
            return _mapper.Map<IList<Model.City>>(list);
        }
    }
}