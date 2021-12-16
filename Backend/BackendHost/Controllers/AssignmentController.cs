using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace BackendHost.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        IAssignmentRepository _assignmentRepository;
        public AssignmentController(IAssignmentRepository assignmentRepository) { _assignmentRepository = assignmentRepository; }

        // GET <AssignmentController>/5
        [HttpGet("{id}")]
        public Assignment Get(int id) { return _assignmentRepository.GetAssignmentById(id); }
    }
}
