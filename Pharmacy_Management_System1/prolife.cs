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
    public partial class prolife : Form
    {
        Function2 f2 = new Function2();
        string query;

        string connectionstring = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
        public prolife()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Administrator A1 = new Administrator();
            A1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtSearchname.Text.All(char.IsLetter) && txtemail.Text.Contains("@") && txtmobile.Text.All(char.IsDigit) && txtname.Text.All(char.IsLetter))
            {
                Admin a1 = new Admin();
                a1.UpdateUsers(txtuserrole.Text, txtSearchname.Text, txtDOB.Text, txtmobile.Text, txtemail.Text, txtname.Text, txtpassword.Text);
                MessageBox.Show("User has been Update Successfully", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The program isn't responding due to incorrect format","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Admin a1 = new Admin();
            //a1.UpdateUsers(txtuserrole.Text, txtSearchname.Text, txtDOB.Text, txtmobile.Text, txtemail.Text, txtname.Text, txtpassword.Text);
            //MessageBox.Show("User has been Update Successfully", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //string userrole = txtuserrole.Text;

            //string uname = txtSearchname.Text;
 
            //string DOB = txtDOB.Text;

            //string contact = txtmobile.Text;
      
            //string Email = txtemail.Text;
            //string U_Name = txtname.Text;
            //string us_Password = txtpassword.Text;


            //query = ("UPDATE AddUser set user_role='" + userrole + "',us_name='" + U_Name + "',dob='" + DOB + "',contact='" + contact + "',email='" + Email + "',us_password='" + us_Password + "' WHERE u_name = '" + txtSearchname.Text + "'");
            //f2.setData(query, "User Detail Updated.");
        }

        private void prolife_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            //{


            //}
            //    try
            //    {
            //        guna2TextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //        Userrole.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        names1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //        DateTime.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //        CN.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //        Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //        Pass.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("You Cannot Select This Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void prolife_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {


            }
            try
            {    }
            catch
            {
                MessageBox.Show("You Cannot Select This Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchname.Text != "")
                {

                    query = ("Select * from AddUser where u_name = '" + txtSearchname.Text + "'");
                    DataSet ds = f2.GetData(query);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtuserrole.Text = ds.Tables[0].Rows[0][0].ToString();

                        txtDOB.Text = ds.Tables[0].Rows[0][2].ToString();

                        txtmobile.Text = ds.Tables[0].Rows[0][3].ToString();

                        txtemail.Text = ds.Tables[0].Rows[0][4].ToString();

                        txtname.Text = ds.Tables[0].Rows[0][5].ToString();

                        txtpassword.Text = ds.Tables[0].Rows[0][6].ToString();

                    }
                    else
                    {
                        MessageBox.Show("This Username does not Exist: " + txtSearchname.Text + " Exit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            txtSearchname.Clear();
            txtDOB.ResetText();
            txtmobile.Clear();
            txtemail.ResetText();
            txtname.ResetText();
            txtpassword.Clear();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
