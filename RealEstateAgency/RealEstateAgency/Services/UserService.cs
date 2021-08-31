using AutoMapper;
using RealEstateAgency.Services;
using RealEstateAgency.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public class UserService : BaseCRUDService<Model.User, Database.User, Model.UserSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>, IUserService
    {
        public UserService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.User> Get(Model.UserSearchRequest search = null)
        {
            var entity = Context.Set<Database.User>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.UserName))
            {
                entity = entity.Where(x => x.UserName.Contains(search.UserName));
            }
            if (!string.IsNullOrWhiteSpace(search.FirstName))
            {
                entity = entity.Where(x => x.FirstName.Contains(search.FirstName));
            }
            if (!string.IsNullOrWhiteSpace(search.LastName))
            {
                entity = entity.Where(x => x.LastName.Contains(search.LastName));
            }
            if (!string.IsNullOrWhiteSpace(search.Email))
            {
                entity = entity.Where(x => x.Email.Contains(search.Email));
            }
            if (!string.IsNullOrWhiteSpace(search.PhoneNumber))
            {
                entity = entity.Where(x => x.PhoneNumber.Contains(search.PhoneNumber));
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.User>>(list);
        }
    }
}
