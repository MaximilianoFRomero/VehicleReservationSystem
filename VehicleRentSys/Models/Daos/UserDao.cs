using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models;

namespace VehicleRentSys.Model.Dao
{
    public class UserDAO
    {
        private List<User> users;

        public UserDAO()
        {
            users = new List<User>();
        }

        public void AddUser(string name, string lastName, string email)
        {
            var user = new User();
            user.name = name;
            user.lastName = lastName;
            user.email = email;
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(user => user.id == id);
        }

        public void UpdateUser(User updatedUser)
        {
            var user = GetUserById(updatedUser.id);
            if (user != null)
            {
                user.name = updatedUser.name;
                user.lastName = updatedUser.lastName;
                user.email = updatedUser.email;
            }
        }

        public void DeletUser(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                users.Remove(user);
            }
        }
    }
}
