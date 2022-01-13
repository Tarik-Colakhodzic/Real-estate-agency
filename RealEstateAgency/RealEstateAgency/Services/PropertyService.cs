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
                if(search.Finished.HasValue && search.Unfinished.HasValue)
                {
                    entity = entity.Where(x => x.Finished == search.Finished.Value || search.Unfinished.Value);
                }
                if(search.Finished.HasValue && !search.Unfinished.HasValue)
                {
                    entity = entity.Where(x => x.Finished == search.Finished.Value);
                }
                if(!search.Finished.HasValue && search.Unfinished.HasValue)
                {
                    entity = entity.Where(x => x.Finished == search.Unfinished.Value);
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
                entity = entity.Include("PropertyPhotos");
            }

            return _mapper.Map<List<Model.Property>>(entity.OrderByDescending(x => x.PublishDate).ToList());
        }

        public bool SetFinished(int id, bool finished)
        {
            try
            {
                var entity = Context.Properties.Find(id);
                entity.Finished = finished;
                Context.Entry(entity).Property(x => x.Finished).IsModified = true;
                Context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}