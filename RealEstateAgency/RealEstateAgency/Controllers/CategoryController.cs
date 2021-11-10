using RealEstateAgency.Services;

namespace RealEstateAgency.Controllers
{
    public class CategoryController : BaseReadController<Model.Category, object>
    {
        public CategoryController(ICategoryService service)
            : base(service)
        {
        }
    }
}