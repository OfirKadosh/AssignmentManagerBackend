using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserRepository
    {
        public void CreateUser(User user);
        public ICollection<User> GetUsers();
        public User GetUserById(int id);
        public User GetUserByName(string username);
        public void UpdateUser(int id, User newUser);
        public void DeleteUser(int id);
    }
}
