using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignInController : ControllerBase
    {
        IUserRepository _repo;
        public SignInController(IUserRepository repo) { _repo = repo; }

        // POST api/<SignInController>
        [HttpPost]
        public User Post([FromBody] User user) => _repo.GetUserByName(user.Username);
    }
}
