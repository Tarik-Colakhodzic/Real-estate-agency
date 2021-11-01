using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class AgentController : BaseCRUDController<Model.Agent, Model.SimpleSearchRequest, Model.Agent, Model.Agent>
    {
        public AgentController(IAgentService service) : base(service)
        {
        }
    }
}