using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class PropertyController : BaseCRUDController<Model.Property, PropertySearchRequest, Model.Property, Model.Property>
    {
        public IPropertyService _propertyService { get; set; }
        public PropertyController(IPropertyService service) : base(service)
        {
            _propertyService = service;
        }

        [HttpPatch("{id}/{finished}")]
        public bool SetFinished(int id, bool finished)
        {
            return _propertyService.SetFinished(id, finished);
        }

    }
}