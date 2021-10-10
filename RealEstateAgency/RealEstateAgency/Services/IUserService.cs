using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public interface IUserService : ICRUDService<Model.User, Model.SimpleSearchRequest, Model.Requests.UserInsertRequest, Model.Requests.UserInsertRequest>
    {
        Task<Model.User> Login(string username, string password);
    }
}
