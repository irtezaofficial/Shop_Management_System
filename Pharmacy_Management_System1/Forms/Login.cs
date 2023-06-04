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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pharmacy_Management_System1.Forms
{
    public partial class Login : Form
    {
        private UserController _userController;
        private ProductController _productController;
        private OrderController _OrderController;
        public Login(UserController userController, ProductController productController, OrderController OrderController)
        {
            InitializeComponent();
            _userController = userController;
            _productController = productController;
            _OrderController = OrderController;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (email.Text != string.Empty && password.Text != string.Empty)
            {
                var request = new LoginRequest
                {

                    Email = email.Text,
                    Password = password.Text,

                };
                var result = this._userController.LoginUser(request);
                MessageBox.Show(result.Message);
                this.Hide();
                if (result.IsAdmin)
                {
                    Menu M1 = new Menu(_userController, _productController);
                    M1.Show();
                }
                else
                {
                    ProductListing pl1 = new ProductListing(_productController,_userController ,_OrderController,result.UserId);
                    pl1.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill the form");
                

            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form r1 = new register(_userController,_productController, _OrderController);
            r1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
