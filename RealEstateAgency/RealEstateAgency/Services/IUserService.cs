namespace RealEstateAgency.Services
{
    public interface IUserService : ICRUDService<Model.User, Model.UserSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
    }
}
