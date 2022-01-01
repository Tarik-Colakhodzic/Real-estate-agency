using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class UserPropertiesService : BaseCRUDService<Model.UserProperties, Database.UserProperties, Model.SimpleSearchRequest, Model.UserProperties, Model.UserProperties>, IUserPropertiesService
    {
        public UserPropertiesService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}