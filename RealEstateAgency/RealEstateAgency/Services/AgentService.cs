using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class AgentService : BaseCRUDService<Model.Agent, Database.Agent, Model.SimpleSearchRequest, Model.Agent, Model.Agent>, IAgentService
    {
        public AgentService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}