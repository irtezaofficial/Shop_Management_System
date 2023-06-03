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
    public partial class ViewUser : Form
    {
        Function2 f2 = new Function2();
        string query;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Administrator().Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyManagmentDataSet.AddUser' table. You can move, or remove it, as needed.
            this.addUserTableAdapter.Fill(this.pharmacyManagmentDataSet.AddUser);

            //query = "Select * from AddUser";
            // DataSet ds = f2.GetData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True");
            SqlCommand cmd1;


            con.Open();
            cmd1 = new SqlCommand("Select * from AddUser", con);
            cmd1.ExecuteNonQuery();

            con.Close();



        }
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            guna2DataGridView1.DataSource = a1.SearchUsers(txtusername.Text);
        }

        string UserName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserName = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
            catch
            {
                MessageBox.Show("You Cannot Select This Row","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.DeleteUsers(UserName);
            MessageBox.Show("User Deleted Successfully", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2DataGridView1.DataSource = a1.ViewUsers();
            //try
            //{

            //    if (MessageBox.Show("Are you sure", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True");
            //        SqlCommand cmd1;
            //        con.Open();
            //        cmd1 = new SqlCommand("DELETE from AddUser where us_name='" + UserName + "'", con);
            //        cmd1.ExecuteNonQuery();
            //        MessageBox.Show("User  deleted successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //con.Close();
            //        ViewUser_Load(this, null);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from AddUser where us_name like '" + txtusername.Text + "%'";
            DataSet ds = f2.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
