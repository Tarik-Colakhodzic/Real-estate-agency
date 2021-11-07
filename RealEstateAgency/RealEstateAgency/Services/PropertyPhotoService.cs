using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class PropertyPhotoService : BaseCRUDService<Model.PropertyPhoto, PropertyPhoto, object, Model.PropertyPhoto, Model.PropertyPhoto>, IPropertyPhotoService
    {
        public PropertyPhotoService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}