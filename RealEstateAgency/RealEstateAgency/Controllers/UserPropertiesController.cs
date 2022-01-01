using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class UserPropertiesController : BaseCRUDController<Model.UserProperties, Model.SimpleSearchRequest, Model.UserProperties, Model.UserProperties>
    {
        public UserPropertiesController(IUserPropertiesService service) : base(service)
        {
        }
    }
}