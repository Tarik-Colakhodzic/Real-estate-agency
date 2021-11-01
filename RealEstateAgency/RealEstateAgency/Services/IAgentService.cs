using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public interface IAgentService : ICRUDService<Model.Agent, Model.SimpleSearchRequest, Model.Agent, Model.Agent>
    {
    }
}