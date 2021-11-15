using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class ContractController : BaseCRUDController<Model.Contract, Model.SimpleSearchRequest, Model.Contract, Model.Contract>
    {
        public ContractController(IContractService service) : base(service)
        {
        }
    }
}