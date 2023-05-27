using Pharmacy_Management_System1.Model;
using Pharmacy_Management_System1.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System1
{
    public partial class TestForm : Form
    {
        private UserController _userController;
        public TestForm(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
        }

        //public TestForm()
        //{
        //    InitializeComponent();
        //}

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (Name.Text != " " && email.Text != " " && password.Text != " ") 
            {
                var request = new RegisterUserRequest
                {
                    Name = Name.Text,
                    Email = email.Text,
                    Password = password.Text,
                    ConfirmPassword = password.Text,
                };
                var result = this._userController.RegisterUser(request);
                _ = result ? MessageBox.Show("User Registered.") : MessageBox.Show("User Already Exists.");
            }
        }
    }
}
