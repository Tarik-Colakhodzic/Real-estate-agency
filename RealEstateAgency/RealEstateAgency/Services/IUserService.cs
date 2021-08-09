using RealEstateAgency.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public interface IUserService
    {
        public List<Model.User> Get();
    }
}
