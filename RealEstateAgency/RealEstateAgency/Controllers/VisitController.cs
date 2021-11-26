using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class VisitController : BaseCRUDController<Model.Visit, Model.SimpleSearchRequest, Model.Visit, Model.Visit>
    {
        public readonly IVisitService _visitService;

        public VisitController(IVisitService service) : base(service)
        {
            _visitService = service;
        }

        [HttpPatch("{id}/{approved}")]
        public bool SetApproved(int id, bool approved)
        {
            return _visitService.SetApproved(id, approved);
        }
    }
}