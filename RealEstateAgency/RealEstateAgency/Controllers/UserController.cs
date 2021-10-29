using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class UserController : BaseCRUDController<Model.User, Model.SimpleSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
        public UserController(IUserService service) : base(service)
        {
        }
    }
}