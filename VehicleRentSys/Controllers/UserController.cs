using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Model.Dao;
using VehicleRentSys.Models;

namespace VehicleRentSys.Controller
{
    public class UserController
    {
        private UserDAO userDAO;

        public UserController()
        {
            userDAO = new UserDAO();
        }

        public void AddNewUser(string name, string lastName, string email)
        {
            userDAO.AddUser(name, lastName, email);
        }

        public List<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }
    }
}
