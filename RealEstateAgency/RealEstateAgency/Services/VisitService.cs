using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class VisitService : BaseCRUDService<Model.Visit, Database.Visit, Model.Requests.VisitSearchRequest, Model.Visit, Model.Visit>, IVisitService
    {
        public VisitService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Visit> Get(Model.Requests.VisitSearchRequest search = null)
        {
            var entity = Context.Set<Database.Visit>().AsQueryable();
            if (search != null)
            {
                if (search.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
                if (!string.IsNullOrWhiteSpace(search.PropertyTitle))
                {
                    entity = entity.Where(x => x.Property.Title.Contains(search.PropertyTitle));
                }
                if (search.ClientId.HasValue)
                {
                    entity = entity.Where(x => x.UserId == search.ClientId);
                }
                if (search.Approved && !search.NotApproved)
                {
                    entity = entity.Where(x => x.Approved == true);
                }
                if (!search.Approved && search.NotApproved)
                {
                    entity = entity.Where(x => x.Approved == false);
                }
            }
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Visit>>(list);
        }

        public bool SetApproved(int id, bool approved)
        {
            try
            {
                var entity = Context.Visits.Find(id);
                entity.Approved = approved;
                Context.Entry(entity).Property(x => x.Approved).IsModified = true;
                Context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}