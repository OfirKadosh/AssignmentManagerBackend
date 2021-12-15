using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackendHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteUserController : ControllerBase
    {
        IUserRepository _repo;
        public DeleteUserController(IUserRepository repo) { _repo = repo; }

        // DELETE api/<DeleteUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) { _repo.DeleteUser(id); }
    }
}
