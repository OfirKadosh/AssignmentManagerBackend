using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeleteUserController : ControllerBase
    {
        IUserRepository _repo;
        public DeleteUserController(IUserRepository repo) { _repo = repo; }

        // DELETE <DeleteUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) { _repo.DeleteUser(id); }
    }
}
