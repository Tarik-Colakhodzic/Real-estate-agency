using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class BookOfComplaintsService : BaseCRUDService<Model.BookOfComplaints, Database.BookOfComplaints, Model.SimpleSearchRequest, Model.BookOfComplaints, Model.BookOfComplaints>, IBookOfComplaintsService
    {
        public BookOfComplaintsService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}