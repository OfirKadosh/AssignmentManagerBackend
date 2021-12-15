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
    public class ConditionAssignmentsController : ControllerBase
    {
        IAssignmentRepository _assignmentRepository;
        public ConditionAssignmentsController(IAssignmentRepository assignmentRepository) { _assignmentRepository = assignmentRepository; }

        // GET api/<ConditionAssignmentsController>/open
        [HttpGet("{condition}")]
        public ICollection<Assignment> Get(string condition) => _assignmentRepository.GetAssignmentsByCondition(condition);
    }
}
