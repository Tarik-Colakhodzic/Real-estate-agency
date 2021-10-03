namespace RealEstateAgency.Services
{
    public interface IUserService : ICRUDService<Model.User, Model.SimpleSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
    }
}
