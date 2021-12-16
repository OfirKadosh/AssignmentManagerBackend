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
    [Route("api/[controller]")]
    [ApiController]
    public class UserAssignmentByDateController : ControllerBase
    {
        IUserRepository _repo;
        public UserAssignmentByDateController(IUserRepository repo) { _repo = repo; }

        // GET <SignInController>/5
        [HttpGet("{id}")]
        public ICollection<Assignment> Get(int id, [FromBody] DateTime firstDate, [FromBody] DateTime lastDate) => _repo.GetUserAssignmentsByDates(id, firstDate, lastDate);
    }
}
