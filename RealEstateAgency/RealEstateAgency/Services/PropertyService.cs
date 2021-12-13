using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class PropertyService : BaseCRUDService<Model.Property, Database.Property, PropertySearchRequest, Model.Property, Model.Property>, IPropertyService
    {
        public PropertyService(RealEstateAgencyContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Property> Get(PropertySearchRequest search = null)
        {
            var entity = Context.Set<Database.Property>().AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.SearchText))
                {
                    entity = entity.Where(x => x.Title.Contains(search.SearchText));
                }
                if (search.Finished && !search.Unfinished)
                {
                    entity = entity.Where(x => x.Finished);
                }
                if (search.Unfinished && !search.Finished)
                {
                    entity = entity.Where(x => !x.Finished);
                }
                if (search.OwnerId.HasValue)
                {
                    entity = entity.Where(x => x.OwnerId == search.OwnerId);
                }
                if (search.AgentId.HasValue)
                {
                    entity = entity.Where(x => x.AgentId == search.AgentId);
                }
                if (search.CategoryId.HasValue)
                {
                    entity = entity.Where(x => x.CategoryId == search.CategoryId);
                }
                if (search.CityId.HasValue)
                {
                    entity = entity.Where(x => x.CityId == search.CityId);
                }
                if (search.CountryId.HasValue)
                {
                    entity = entity.Where(x => x.City.CountryId == search.CountryId);
                }
                if (search.OfferTypeId.HasValue)
                {
                    entity = entity.Where(x => x.OfferTypeId == search.OfferTypeId);
                }
                if(search.Start.HasValue)
                {
                    entity = entity.Where(x => x.PublishDate > search.Start);
                }
                if(search.End.HasValue)
                {
                    entity = entity.Where(x => x.PublishDate < search.End);
                }
                if (search?.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
            }

            return _mapper.Map<List<Model.Property>>(entity.OrderByDescending(x => x.PublishDate).ToList());
        }
    }
}