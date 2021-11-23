using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class VisitService : BaseCRUDService<Model.Visit, Database.Visit, Model.SimpleSearchRequest, Model.Visit, Model.Visit>, IVisitService
    {
        public VisitService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}