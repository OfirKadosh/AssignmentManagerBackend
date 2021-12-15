using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAssignmentRepository
    {
        public void CreateAssignment(Assignment assignment);
        public ICollection<Assignment> GetAssignments();
        public Assignment GetAssignmentById(int id);
        public void UpdateAssignment(int id, Assignment newAssignment);
        public void DeleteAssignment(int id);
        ICollection<Assignment> GetAssignmentsByCondition(string condition);
    }
}
