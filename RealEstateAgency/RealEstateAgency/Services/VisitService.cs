using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class VisitService : BaseCRUDService<Model.Visit, Database.Visit, Model.SimpleSearchRequest, Model.Visit, Model.Visit>, IVisitService
    {
        public VisitService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
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