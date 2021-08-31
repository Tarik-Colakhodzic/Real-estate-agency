using RealEstateAgency.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public interface IUserService : ICRUDService<Model.User, Model.UserSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
    }
}
