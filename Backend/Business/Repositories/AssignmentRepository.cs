using Data;
using Business.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        AmContext _context;
        public AssignmentRepository(AmContext context)
        {
            _context = context;
        }

        public void CreateAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
        }

        public void DeleteAssignment(int id)
        {
            var foundedAssignment = _context.Assignments.SingleOrDefault(assignment => assignment.AssignmentId == id);
            _context.Assignments.Remove(foundedAssignment);
            _context.SaveChanges();
        }

        public Assignment GetAssignmentById(int id) => _context.Assignments.Find(id) ?? throw new Exception("Assignment not found"); //assignment existing check

        public ICollection<Assignment> GetAssignments() => _context.Assignments.ToList();

        public ICollection<Assignment> GetAssignmentsByCondition(string condition)
        {
            switch (condition)
            {
                case "open":
                    return GetAssignments().Where(a => a.Status == Status.InProgress).ToList();
                case "closed":
                    return GetAssignments().Where(a => a.Status == Status.Done || a.Status == Status.Cancelled).ToList();
                case "near":
                    return GetAssignments().Where(a => a.Deadline == DateTime.Now.AddDays(7)).ToList();
                case "all":
                    return GetAssignments();
                default:
                    return default;
            }
        }

        public void UpdateAssignment(int id, Assignment newAssignment)
        {
            var foundedAssignment = _context.Assignments.Find(id);
            if (!(foundedAssignment is null)) // assignment existing check
            {
                foundedAssignment.CreatedAt = newAssignment.CreatedAt;
                foundedAssignment.Deadline = newAssignment.Deadline;
                foundedAssignment.Description = newAssignment.Description;
                foundedAssignment.InChargeOf = newAssignment.InChargeOf;
                foundedAssignment.Status = newAssignment.Status;
                foundedAssignment.Title = newAssignment.Title;
                foundedAssignment.Urgency = newAssignment.Urgency;
                _context.SaveChanges();
            }
            else throw new Exception("Assignment not found");
        }
    }
}
