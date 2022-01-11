using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class BookOfComplaintsService : BaseCRUDService<Model.BookOfComplaints, Database.BookOfComplaints, BookOfComplaintsSearchRequest, Model.BookOfComplaints, Model.BookOfComplaints>, IBookOfComplaintsService
    {
        public BookOfComplaintsService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IEnumerable<Model.BookOfComplaints> Get(BookOfComplaintsSearchRequest search = null)
        {
            var entity = Context.Set<Database.BookOfComplaints>().AsQueryable();
            if (search != null)
            {
                if (search.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
                if (search.AgentId.HasValue)
                {
                    entity = entity.Where(x => x.AgentId == search.AgentId);
                }
            }
            var list = entity.ToList();
            return _mapper.Map<IList<Model.BookOfComplaints>>(list);
        }
    }
}