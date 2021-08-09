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
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.User> Get()
        {
            return _service.Get();
        }

        //[HttpPost]
        //public User Insert([FromBody] KorisniciInsertRequest request)
        //{
        //    return _service.Insert(request);
        //}
    }
}
