using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        IUserRepository _repo;
        public SignUpController(IUserRepository repo) { _repo = repo; }
        
        // POST api/<SignUpController>
        [HttpPost]
        public void Post([FromBody] User newUser) { _repo.CreateUser(newUser); }
    }
}
