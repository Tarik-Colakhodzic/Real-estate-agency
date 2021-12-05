using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class OwnerService : BaseCRUDService<Model.Owner, Database.Owner, Model.SimpleSearchRequest, Model.Owner, Model.Owner>, IOwnerService
    {
        public OwnerService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Owner> Get(SimpleSearchRequest search = null)
        {
            var entity = Context.Set<Database.Owner>().AsQueryable();
            if (search != null)
            {
                if (search.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
                if (!string.IsNullOrWhiteSpace(search.SearchText))
                {
                    entity = entity.Where(x => x.FirstName.Contains(search.SearchText) || x.LastName.Contains(search.SearchText) || x.Email.Contains(search.SearchText));
                }
            }
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Owner>>(list);
        }
    }
}