using AutoMapper;
using RealEstateAgency.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Services
{
    public class UserService : IUserService
    {
        public RealEstateAgencyContext Context { get; set; }

        private readonly IMapper _mapper;

        public UserService(RealEstateAgencyContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public List<Model.User> Get()
        {
            return Context.Users.Select(x => _mapper.Map<Model.User>(x)).ToList();
        }
    }
}
