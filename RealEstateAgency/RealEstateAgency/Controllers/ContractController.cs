using Microsoft.AspNetCore.Authorization;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    [Authorize(Roles = "Administrator,Agent")]
    public class ContractController : BaseCRUDController<Model.Contract, Model.Requests.ContractSearchRequest, Model.Contract, Model.Contract>
    {
        public ContractController(IContractService service) : base(service)
        {
        }
    }
}