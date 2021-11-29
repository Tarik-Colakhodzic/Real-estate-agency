using RealEstateAgency.Model.Requests;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class PropertyController : BaseCRUDController<Model.Property, PropertySearchRequest, Model.Property, Model.Property>
    {
        public PropertyController(IPropertyService service) : base(service)
        {
        }
    }
}