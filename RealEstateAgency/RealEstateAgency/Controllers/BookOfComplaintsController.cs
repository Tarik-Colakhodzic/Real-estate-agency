using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class BookOfComplaintsController : BaseCRUDController<Model.BookOfComplaints, Model.Requests.BookOfComplaintsSearchRequest, Model.BookOfComplaints, Model.BookOfComplaints>
    {
        public BookOfComplaintsController(IBookOfComplaintsService service) : base(service)
        {
        }
    }
}