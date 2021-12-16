using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CreateAssignmentController : ControllerBase
    {
        IAssignmentRepository _assignmentRepository;
        public CreateAssignmentController(IAssignmentRepository assignmentRepository) { _assignmentRepository = assignmentRepository; }

        // POST <CreateAssignmentController>
        [HttpPost]
        public void Post([FromBody] Assignment assignment) { _assignmentRepository.CreateAssignment(assignment); }
    }
}
