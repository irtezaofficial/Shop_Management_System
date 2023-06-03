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
    public partial class ViewMed : Form
    {
        public ViewMed()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pharmasist f1 = new Pharmasist();
            f1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewMed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addAmedDataSet1.pht' table. You can move, or remove it, as needed.
            this.phtTableAdapter1.Fill(this.addAmedDataSet1.pht);

            // TODO: This line of code loads data into the 'addAmedDataSet.pht' table. You can move, or remove it, as needed.
            this.phtTableAdapter.Fill(this.addAmedDataSet.pht);
            // TODO: This line of code loads data into the 'addmedDataSet.pharma' table. You can move, or remove it, as needed.
            this.phtTableAdapter.Fill(this.addAmedDataSet.pht);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
            SqlCommand cmd1;


            con.Open();
            cmd1 = new SqlCommand("Select * from pht", con);
            cmd1.ExecuteNonQuery();

            con.Close();



        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
            //con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter("Select * from pht Where mname like '%" + txtSearchUser.Text + "%'", con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //guna2DataGridView1.DataSource = dt;
        }

        string medicineID;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from pht Where mname like '%" + txtSearchUser.Text + "%'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    PharmacistOperations A1 = new PharmacistOperations();
                    A1.DeleteMedicine(medicineID);
                    MessageBox.Show("Medicine deleted successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2DataGridView1.DataSource = A1.ViewMedicine();
                    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
                    //SqlCommand cmd1;
                    //con.Open();
                    //cmd1 = new SqlCommand("DELETE from pht where mid='" + medicineID + "'",con);
                    //cmd1.ExecuteNonQuery();
                    //MessageBox.Show("Medicine deleted successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //con.Close();
                    //ViewMed_Load(this, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





        }
            
        }
    }
