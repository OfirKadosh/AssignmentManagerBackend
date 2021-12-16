using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EditAssignmentController : ControllerBase
    {
        IAssignmentRepository _assignmentRepository;
        public EditAssignmentController(IAssignmentRepository assignmentRepository) { _assignmentRepository = assignmentRepository; }

        // PUT <EditAssignmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Assignment newAssignment) { _assignmentRepository.UpdateAssignment(id, newAssignment); }
    }
}
