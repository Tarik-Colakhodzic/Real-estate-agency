using RealEstateAgency.Database;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class OwnerController : BaseCRUDController<Model.Owner, Model.SimpleSearchRequest, Model.Owner, Model.Owner>
    {
        public OwnerController(IOwnerService service) : base(service)
        {
        }
    }
}