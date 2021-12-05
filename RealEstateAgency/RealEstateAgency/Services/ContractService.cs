using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Database;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateAgency.Services
{
    public class ContractService : BaseCRUDService<Model.Contract, Database.Contract, Model.Requests.ContractSearchRequest, Model.Contract, Model.Contract>, IContractService
    {
        public ContractService(RealEstateAgencyContext context, IMapper mapper)
        : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Contract> Get(Model.Requests.ContractSearchRequest search = null)
        {
            var entity = Context.Set<Database.Contract>().AsQueryable();
            if (search != null)
            {
                if (search.IncludeList?.Length > 0)
                {
                    foreach (var item in search.IncludeList)
                    {
                        entity = entity.Include(item);
                    }
                }
                if (!string.IsNullOrWhiteSpace(search.PropertyTitle))
                {
                    entity = entity.Where(x => x.Property.Title.Contains(search.PropertyTitle));
                }
                if (search.AgentId.HasValue)
                {
                    entity = entity.Where(x => x.AgentId == search.AgentId);
                }
                if (search.OwnerId.HasValue)
                {
                    entity = entity.Where(x => x.Property.OwnerId == search.OwnerId);
                }
                if (search.ClientId.HasValue)
                {
                    entity = entity.Where(x => x.UserId == search.ClientId);
                }
            }
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Contract>>(list);
        }
    }
}