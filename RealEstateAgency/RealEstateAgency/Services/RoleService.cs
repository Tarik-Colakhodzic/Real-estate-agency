using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class RoleService : BaseReadService<Model.Role, Database.Role, object>, IRoleService
    {
        public RoleService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}