using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateUserController : ControllerBase
    {
        IUserRepository _repo;
        public UpdateUserController(IUserRepository userRepository) { _repo = userRepository; }

        // PUT api/<UpdateUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User newUser) { _repo.UpdateUser(id, newUser); }
    }
}
