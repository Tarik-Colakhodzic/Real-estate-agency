using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Database;
using RealEstateAgency.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Controllers
{
    public class UserController : BaseReadController<Model.User, Model.UserSearchObject>
    {
        public UserController(IUserService service) : base(service)
        {
        }
    }
}
