using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentSys.Controller;

namespace VehicleRentSys.UserInterface
{
    public partial class Home : Form
    {
        UserController userController = new UserController();
        public Home()
        {
            InitializeComponent();

        }



        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            userController.AddNewUser(txtName.Text, txtLastName.Text, "email");
            fillCmbUsers();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void fillCmbUsers()
        {
            cmbUsers.DataSource = userController.GetAllUsers();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
