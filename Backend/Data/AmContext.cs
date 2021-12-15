using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;

namespace Data
{
    public class AmContext : DbContext
    {
        public AmContext(DbContextOptions<AmContext> options) : base(options) { }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var adminUser = new User { UserId = 1, Username = "Admin", EmailAdress = "ofir.kadoshosh@gmail.com", Password = "Admin", IsAdmin = true };
            modelBuilder.Entity<User>().HasData(
                adminUser,
                new User { UserId = 3, Username = "Jane", EmailAdress = "jane.doe@gmail.com", Password = "12345678", IsAdmin = false },
                new User { UserId = 2, Username = "John", EmailAdress = "john.doe@gmail.com", Password = "12345678", IsAdmin = false }
                ); //creating data for users.
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { AssignmentId = 1, Title = "firstAssign", Description = "first description", InChargeOfId= adminUser.UserId, Urgency = Urgency.Medium, Status = Status.InProgress, CreatedAt = DateTime.Now, Deadline = DateTime.Now.AddDays(10) },
                new Assignment { AssignmentId = 2, Title = "secondAssign", Description = "second description", InChargeOfId = adminUser.UserId, Urgency = Urgency.High, Status = Status.Done, CreatedAt = DateTime.Now.AddDays(-8), Deadline = DateTime.Now.AddDays(2) },
                new Assignment { AssignmentId = 3, Title = "thirdAssign", Description = "third description", InChargeOfId = adminUser.UserId, Urgency = Urgency.Low, Status = Status.Pending, CreatedAt = DateTime.Now.AddDays(2), Deadline = DateTime.Now.AddDays(12) },
                new Assignment { AssignmentId = 4, Title = "forthAssign", Description = "forth description", InChargeOfId = adminUser.UserId, Urgency = Urgency.Medium, Status = Status.InProgress, CreatedAt = DateTime.Now.AddDays(-2), Deadline = DateTime.Now.AddDays(8) },
                new Assignment { AssignmentId = 5, Title = "fifthAssign", Description = "fifth description", InChargeOfId = adminUser.UserId, Urgency = Urgency.Medium, Status = Status.InProgress, CreatedAt = DateTime.Now.AddDays(-3), Deadline = DateTime.Now.AddDays(7) },
                new Assignment { AssignmentId = 6, Title = "sixthAssign", Description = "sixth description", InChargeOfId = adminUser.UserId, Urgency = Urgency.Low, Status = Status.Cancelled, CreatedAt = DateTime.Now.AddDays(1), Deadline = DateTime.Now.AddDays(11) }
            );
            //creating data for assignments.
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
