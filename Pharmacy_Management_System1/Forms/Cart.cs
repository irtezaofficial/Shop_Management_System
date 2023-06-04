using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Cart : Form
    {
        private ProductController _productController;
        private UserController _userController;
        private OrderController _OrderController;
        private int UserId;
        public Cart(ProductController productController, UserController userController, OrderController OrderController, int userId)
        {
            InitializeComponent();
            _productController = productController;
            _userController = userController;
            _OrderController = OrderController;
            UserId = userId;
            var order = _OrderController.GetCurrentUserCart(userId);
            foreach (var orderdetail in order.OrderDetails)
            {
                CartItems.Items.Add(orderdetail.Product.Name);
            }
        }

        private void CartItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = CartItems.GetItemText(CartItems.SelectedItem);
            var order = _OrderController.GetCurrentUserCart(UserId);
            var od= order.OrderDetails.FirstOrDefault(ode => ode.Product.Name.Contains(name));
            Pname.Text = name;
            pqty.Text = od.Quantity.ToString();
            pamt.Text = od.Total.ToString();
            pdisc.Text = od.Discount.ToString();
            bill.Text = order.TotalAmount.ToString();


        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
