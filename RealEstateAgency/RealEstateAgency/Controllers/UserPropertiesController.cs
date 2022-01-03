using RealEstateAgency.Model.Requests;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class UserPropertiesController : BaseCRUDController<Model.UserProperties, UserPropertiesSearchRequest, Model.UserProperties, Model.UserProperties>
    {
        public UserPropertiesController(IUserPropertiesService service) : base(service)
        {
        }
    }
}