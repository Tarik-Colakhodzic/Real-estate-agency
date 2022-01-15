using RealEstateAgency.Services;
using Microsoft.AspNetCore.Authorization;
using RealEstateAgency.Model;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Model.Requests;

namespace RealEstateAgency.Controllers
{
    public class UserController : BaseCRUDController<Model.User, Model.SimpleSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
        public UserController(IUserService service) : base(service)
        {
        }

        [AllowAnonymous]
        public override User Insert([FromBody] UserInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        public override User Update(int id, [FromBody] UserInsertRequest request)
        {
            return base.Update(id, request);
        }
    }
}