using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using RealEstateAgency.Model.Requests;
using System;
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
                    entity = entity.Where(x => x.Finished == true);
                }
                if (!search.Finished && search.Unfinished)
                {
                    entity = entity.Where(x => x.Finished == false);
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
                entity = entity.Include(Model.EntityNames.PropertyPhotos);
                entity = entity.Include(Model.EntityNames.UserProperties);
            }

            return OrderPropertiesByRecommentedSystem(entity);
        }

        public bool SetFinished(int id, bool finished)
        {
            var entity = Context.Properties.Find(id);
            entity.Finished = finished;
            Context.Entry(entity).Property(x => x.Finished).IsModified = true;
            Context.SaveChanges();
            return true;
        }

        public IEnumerable<Model.Property> OrderPropertiesByRecommentedSystem(IQueryable<Property> properties)
        {
            var propertiesRating = new List<Tuple<int, Property>>();
            foreach (var item in properties)
            {
                propertiesRating.Add(Tuple.Create(item.UserProperties.Count, item));
            }
            propertiesRating = propertiesRating.OrderByDescending(x => x.Item1).ToList();
            var orderedList = propertiesRating.Select(x => x.Item2);
            return _mapper.Map<List<Model.Property>>(orderedList);
        }
    }
}