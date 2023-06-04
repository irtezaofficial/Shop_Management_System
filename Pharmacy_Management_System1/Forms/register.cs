using Pharmacy_Management_System1.Model.Order;
using Pharmacy_Management_System1.Model.Product;
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
        private ProductController _productcontroller;
        private OrderController _OrderController;
        public register(UserController userController, ProductController productController, OrderController OrderController)
        {
            InitializeComponent();
            _userController = userController;
            _productcontroller = productController;
            _OrderController = OrderController;
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
                this.Hide();
                Form L1 = new Login(_userController,_productcontroller, _OrderController);
                L1.Show();
            }
            else {
                MessageBox.Show("Please fill the form");
            }
        }

        private void cpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
