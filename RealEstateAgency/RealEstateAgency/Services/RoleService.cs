using AutoMapper;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
