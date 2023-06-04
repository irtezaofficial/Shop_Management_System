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
    public partial class Menu : Form
    {
        private UserController _userController;
        private ProductController _productcontroller;
        public Menu(UserController userController , ProductController productController)
        {
            InitializeComponent();
            _userController = userController;
            _productcontroller = productController;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            AddProduct F1 = new AddProduct(_productcontroller, _userController);
            F1.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            updateProductListing UPL1 = new updateProductListing(_productcontroller, _userController);
            UPL1.Show();
        }
    }
}
