using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        public RealEstateAgencyContext Context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(RealEstateAgencyContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<TDb>();

            //TODO pogledati optimizaciju i kod
            var simpleSearch = search as Model.SimpleSearchRequest;
            if(simpleSearch != null)
            {
                var includeEntities = entity.AsQueryable();
                if (simpleSearch?.IncludeList?.Length > 0)
                {
                    foreach (var item in simpleSearch.IncludeList)
                    {
                        includeEntities = includeEntities.Include(item);
                    }
                }
                var result = includeEntities.ToList();
                return _mapper.Map<List<T>>(result);
            }

            var list = entity.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}