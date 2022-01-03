using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class UserPropertiesService : BaseCRUDService<Model.UserProperties, Database.UserProperties, UserPropertiesSearchRequest, Model.UserProperties, Model.UserProperties>, IUserPropertiesService
    {
        public UserPropertiesService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IEnumerable<Model.UserProperties> Get(UserPropertiesSearchRequest search = null)
        {
            var entity = Context.Set<Database.UserProperties>().AsQueryable();

            if(search?.UserId != null)
            {
                entity = entity.Where(x => x.UserId == search.UserId);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.UserProperties>>(list);
        }
    }
}