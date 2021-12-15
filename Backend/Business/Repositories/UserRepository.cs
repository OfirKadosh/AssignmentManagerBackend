using Data;
using Business.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class UserRepository : IUserRepository
    {
        AmContext _context;
        public UserRepository(AmContext context) { _context = context; }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var foundedUser = _context.Users.SingleOrDefault(user => user.UserId == id);
            _context.Users.Remove(foundedUser);
            _context.SaveChanges();
        }

        public User GetUserById(int id) => _context.Users.Find(id) ?? throw new Exception("User not found"); //user existing check by id
        public User GetUserByName(string username)
        {
            var users = GetUsers();
            foreach (var user in users)
            {
                if (user.Username == username)
                    return user;
            }
            return default;
        } //user existing check by username
        public ICollection<User> GetUsers() => _context.Users.ToList();

        public void UpdateUser(int id, User newUser)
        {
            var foundedUser = _context.Users.Find(id);
            if (!(foundedUser is null)) // user existing check
            {
                if (!(newUser.EmailAdress is null)) foundedUser.EmailAdress = newUser.EmailAdress;
                if (!(newUser.Password is null)) foundedUser.Password = newUser.Password;
                if (!(newUser.Username is null)) foundedUser.Username = newUser.Username;
                _context.SaveChanges();
            }
            else throw new Exception("User not found");
        }
    }
}
