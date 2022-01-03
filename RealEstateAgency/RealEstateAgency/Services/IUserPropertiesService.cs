using RealEstateAgency.Model.Requests;

namespace RealEstateAgency.Services
{
    public interface IUserPropertiesService : ICRUDService<Model.UserProperties, UserPropertiesSearchRequest, Model.UserProperties, Model.UserProperties>
    {
    }
}