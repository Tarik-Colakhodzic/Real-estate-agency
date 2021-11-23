using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class VisitController : BaseCRUDController<Model.Visit, Model.SimpleSearchRequest, Model.Visit, Model.Visit>
    {
        public VisitController(IVisitService service) : base(service)
        {
        }
    }
}