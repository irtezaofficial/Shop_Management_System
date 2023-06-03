using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System1
{
    public partial class SignUp : Form
    {

        string FirstName;
        string ermail;
        string Pass;
        string C_Pass;




        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=SUP;Integrated Security=True");
        SqlCommand cmd;




        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text != "") && (textBox1.Text != "") && (txtPassword.Text != "") && (textBox3.Text != ""))
            {
                FirstName = txtUsername.Text;
                
                ermail = textBox1.Text;
                Pass = txtPassword.Text;
                C_Pass = textBox3.Text;
                if (txtPassword.Text != textBox3.Text)
                {
                    lblConfirm.Text = "Password Does not Match";
                    lblConfirm.ForeColor = System.Drawing.Color.Red;
                }
                else
                {

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Record VALUES('" + FirstName + "','" + Pass + "','" + C_Pass + "','" + ermail + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successful");
                    con.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("You cannot Make Fields Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
