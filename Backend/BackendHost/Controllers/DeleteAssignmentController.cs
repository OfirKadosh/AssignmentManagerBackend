using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeleteAssignmentController : ControllerBase
    {
        IAssignmentRepository _assignmentRepository;
        public DeleteAssignmentController(IAssignmentRepository assignmentRepository) { _assignmentRepository = assignmentRepository; }

        // DELETE <DeleteAssignmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) { _assignmentRepository.DeleteAssignment(id); }
    }
}
