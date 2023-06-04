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
    public partial class updateProductListing : Form
    {
        private ProductController _productController;
        private UserController _userController;
    
        public updateProductListing(ProductController productController, UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _productController = productController;

            Refresh();
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = ProductList.GetItemText(ProductList.SelectedItem);
            var product = _productController.GetProductByName(name);
           
            Pname.Text = product.Name;
            prc.Text = product.Price.ToString();
            qty.Text = product.Quantity.ToString();
            disc.Text = product.Discount.ToString();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String name = ProductList.GetItemText(ProductList.SelectedItem);
            var product = _productController.GetProductByName(name);
           var deleteproductResult = _productController.DeleteProduct(product.Id);
            MessageBox.Show(deleteproductResult);
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = ProductList.GetItemText(ProductList.SelectedItem);
            var product = _productController.GetProductByName(name);

            if (Pname.Text != string.Empty && prc.Text != string.Empty && qty.Text != string.Empty && disc.Text != string.Empty
                && int.TryParse(qty.Text, out int qtyy) && int.TryParse(prc.Text, out int price) &&
                float.TryParse(disc.Text, out float discount))
            {
                var request = new UpdateProductRequest()
                {
                    Id=product.Id,
                    Name = Pname.Text,
                    Price = price,
                    Quantity = qtyy,
                    Discount = discount
                };
                var result = this._productController.UpdateProduct(request);
                MessageBox.Show(result);
                Refresh();

            }
            else
            {
                MessageBox.Show("Please fill the form correctly");
            }
          
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

            Refresh();
          
            
        }
        public override void Refresh() {
            Pname.Clear();
            prc.Clear();
            qty.Clear();
            disc.Clear();
            ProductList.Items.Clear();
            var products = _productController.GetProductList();
            foreach (var product in products)
            {
                ProductList.Items.Add(product.Name);
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct AP1 = new AddProduct(_productController, _userController);
            AP1.Show();

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            Menu m1 = new Menu(_userController,_productController);
        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M1 = new Menu(_userController, _productController);
            M1.Show();
        }
    }
}
