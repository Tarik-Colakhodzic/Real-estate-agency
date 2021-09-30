using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Database;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class RoleController : BaseReadController<Model.Role, object>
    {
        public RoleController(IRoleService service)
            : base(service)
        {
        }
    }
}
