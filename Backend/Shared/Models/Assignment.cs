using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int InChargeOfId { get; set; }
        [ForeignKey("InChargeOfId")]
        public virtual User InChargeOf { get; set; }
        public Status Status { get; set; }
        public Urgency Urgency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }

        public Assignment(string title, string description, User inChargeOf, Urgency urgency, Status status, DateTime createdAt, DateTime deadline) : this(title, description, urgency, status, createdAt, deadline)
        {
            if (!(inChargeOf is null)) InChargeOf = inChargeOf;
            else throw new Exception("User not found");
        }

        private Assignment(string title, string description, Urgency urgency, Status status, DateTime createdAt, DateTime deadline)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description;
            Urgency = urgency;
            Status = status;
            if (createdAt.Subtract(deadline) < TimeSpan.Zero)
            {
                CreatedAt = createdAt;
                Deadline = deadline;
            }
            else throw new Exception("Deadline is before the time created");
        }
        public Assignment() { }
    }
}
