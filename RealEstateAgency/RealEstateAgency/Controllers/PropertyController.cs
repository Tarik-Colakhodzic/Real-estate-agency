using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class PropertyController : BaseCRUDController<Model.Property, Model.SimpleSearchRequest, Model.Property, Model.Property>
    {
        public PropertyController(IPropertyService service) : base(service)
        {
        }
    }
}