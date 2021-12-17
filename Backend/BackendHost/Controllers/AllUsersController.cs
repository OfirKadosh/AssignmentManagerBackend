using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AllUsersController : ControllerBase
    {
        IUserRepository _repo;
        public AllUsersController(IUserRepository userRepository) { _repo = userRepository; }

        // GET <AllUsersController>
        [HttpGet]
        public ICollection<User> Get() => _repo.GetUsers();
    }
}
