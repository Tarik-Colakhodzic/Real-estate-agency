using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Model;
using RealEstateAgency.Services;
using System.Collections.Generic;

namespace RealEstateAgency.Controllers
{
    public class RoleController : BaseReadController<Model.Role, object>
    {
        public RoleController(IRoleService service)
            : base(service)
        {
        }

        [AllowAnonymous]
        public override IEnumerable<Role> Get([FromQuery] object search)
        {
            return base.Get(search);
        }
    }
}