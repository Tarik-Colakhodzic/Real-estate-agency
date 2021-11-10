using AutoMapper;
using RealEstateAgency.Database;

namespace RealEstateAgency.Services
{
    public class CategoryService : BaseReadService<Model.Category, Database.Category, object>, ICategoryService
    {
        public CategoryService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }
    }
}