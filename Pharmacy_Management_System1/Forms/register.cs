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

namespace Pharmacy_Management_System1.Forms
{
    public partial class register : Form
    {
        private UserController _userController;
        public register(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            name.Clear();
            email.Clear();
            password.Clear();
            cpassword.Clear();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (name.Text != string.Empty && email.Text != string.Empty && password.Text != string.Empty && cpassword.Text != string.Empty)
            {
                var request = new RegisterUserRequest
                {
                    Name = name.Text,
                    Email = email.Text,
                    Password = password.Text,
                    ConfirmPassword = cpassword.Text,
                };
                var result = this._userController.RegisterUser(request);
                MessageBox.Show(result);
            }
            else {
                MessageBox.Show("Please fill the form");
            }
        }
    }
}
