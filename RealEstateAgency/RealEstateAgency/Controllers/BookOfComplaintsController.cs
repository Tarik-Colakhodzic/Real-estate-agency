using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class BookOfComplaintsController : BaseCRUDController<Model.BookOfComplaints, Model.SimpleSearchRequest, Model.BookOfComplaints, Model.BookOfComplaints>
    {
        public BookOfComplaintsController(IBookOfComplaintsService service) : base(service)
        {
        }
    }
}