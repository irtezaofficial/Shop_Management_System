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
    public partial class AddUser : Form
    {
        function fn = new function();
    
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            

            if (txtUserRole.Text != "" && txtName.Text != "" && txtDOB.Text != "" && txtCN.Text != "" && txtEmail.Text != "" && txtUN.Text != "" && txtPass.Text != "" && txtName.Text.All(char.IsLetter) && txtEmail.Text.Contains("@") && txtCN.Text.All(char.IsDigit) && txtUN.Text.All(char.IsLetter)) 
            {
                Admin a1 = new Admin();
                a1.Adduser(txtUserRole.Text, txtName.Text, txtDOB.Text, txtCN.Text, txtEmail.Text, txtUN.Text, txtPass.Text);
                MessageBox.Show("User Has Been Successfully Added", "Successfully User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Enter Fields Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserRole.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            txtCN.Text = "";
            txtEmail.Text = "";
            txtUN.Text = "";
            txtPass.Text = "";
        }

        private void txtCN_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Administrator A = new Administrator();
            A.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            new Administrator().Show();
            
            this.Hide();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
