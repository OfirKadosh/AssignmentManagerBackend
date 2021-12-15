using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public User(string username, string emailAdress, string password, bool isAdmin)
        {
            if (!String.IsNullOrWhiteSpace(username)) EmailAdress = emailAdress;
            else throw new Exception("Must enter a valid email.");
            if (!String.IsNullOrWhiteSpace(username)) Username = username;
            else throw new Exception("Must enter a valid username.");
            if (!String.IsNullOrWhiteSpace(password)) Password = password;
            else throw new Exception("Must enter a valid password.");
            IsAdmin = isAdmin;
        }
        public User() { }
    }
}
