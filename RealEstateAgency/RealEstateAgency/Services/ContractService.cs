using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class ContractService : BaseCRUDService<Model.Contract, Database.Contract, Model.SimpleSearchRequest, Model.Contract, Model.Contract>, IContractService
    {
        public ContractService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}