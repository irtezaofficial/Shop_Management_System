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
    public partial class ProductListing : Form
    {
        private ProductController _productController;
        private UserController _userController;
        private OrderController _OrderController;
        private int UserId;
        public ProductListing(ProductController productController,UserController userController, OrderController OrderController , int userId)
        {
            InitializeComponent();
            _productController = productController;
            _userController = userController;
            _OrderController = OrderController;
            UserId = userId;
            var products = _productController.GetProductList();
            foreach (var product in products)
            {
                ProductList.Items.Add(product.Name);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = ProductList.GetItemText(ProductList.SelectedItem);
            var product = _productController.GetProductByName(name);


            Pname.Text = product.Name;
            prc.Text = product.Price.ToString();
            
        }

        private void pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void prc_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var request = new AddToCartRequest
            {
                UserId = UserId,
                Quantity = int.Parse( qty.Text),
                ProductName = Pname.Text,
                
            };
            var result= _OrderController.AddToCart(request);
            MessageBox.Show(result);
        }

        private void ProductListing_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M1 = new Menu(_userController,_productController);
            M1.Show();
        }

        private void gunaAdvenceButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cart c1 = new Cart(_productController,_userController,_OrderController,UserId);
            c1.Show();
        }
    }
}
