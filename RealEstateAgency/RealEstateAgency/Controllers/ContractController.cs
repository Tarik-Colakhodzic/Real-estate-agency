using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class ContractController : BaseCRUDController<Model.Contract, Model.Requests.ContractSearchRequest, Model.Contract, Model.Contract>
    {
        public ContractController(IContractService service) : base(service)
        {
        }
    }
}