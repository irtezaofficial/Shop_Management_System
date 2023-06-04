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
using System.Xml.Linq;
using Pharmacy_Management_System1.Model.Product;

namespace Pharmacy_Management_System1.Forms
{
    public partial class AddProduct : Form
    {
        private ProductController _productController;
        private UserController _userController;
        public AddProduct(ProductController productController, UserController userController)
        {
            InitializeComponent();
            _productController = productController;
            _userController = userController;
        }
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
                if (pname.Text != string.Empty && prc.Text != string.Empty && qty.Text != string.Empty && disc.Text != string.Empty
                    && int.TryParse(qty.Text, out int qtyy) && int.TryParse(prc.Text, out int price) &&
                    float.TryParse(disc.Text, out float discount))
                {
                    var request = new AddProductRequest()
                    {
                        Name = pname.Text,
                        Price = price,
                        Quantity = qtyy,
                        Discount = discount
                    };
                    var result = this._productController.AddProduct(request);
                    MessageBox.Show(result);
                this.Hide();
                updateProductListing UPL1 = new updateProductListing(_productController, _userController);
                UPL1.Show();
                
                }
                else
                {
                    MessageBox.Show("Please fill the form correctly");
                }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            pname.Clear();
            prc.Clear();
            qty.Clear();
            disc.Clear();

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M1 = new Menu(_userController, _productController);
            M1.Show();
        }
    }
}
