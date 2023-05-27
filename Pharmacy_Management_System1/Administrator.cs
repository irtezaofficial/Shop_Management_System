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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //uC_AddUser1.Visible = true;
           
            //btnAdduser.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
                
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddUser AU = new AddUser();
            AU.Show();
            this.Hide() ;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          

        }

        private void P_Panel_Paint(object sender, PaintEventArgs e)
        {
            
       

        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {
          

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ViewUser VU = new ViewUser();
            VU.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            prolife p = new prolife();
            p.Show();
            this.Hide();
        }

        private void uC_AddUser1_Load_1(object sender, EventArgs e)
        {
            
            //txtUserRole.Text, txtName.Text, txtDOB.Text, txtCN.Text, txtEmail.Text, txtUN.Text, txtPass.Text
        }

        private void VU_Panel_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void uC_ViewUser2_Load(object sender, EventArgs e)
        {

        }

        private void VU_Panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AU_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
