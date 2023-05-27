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
    public partial class UPD_Med : Form
    {
        function fn = new function();
        string query;
        public UPD_Med()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pharmasist P1 = new Pharmasist();
            P1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (txtSearchMed.Text!="")
            {
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
                //SqlCommand cmd1;
                //con.Open();
                //cmd1 = new SqlCommand("Select * from pht where mid = '"+txtSearchMed.Text+"'", con);
                query=("Select * from pht where mid = '" + txtSearchMed.Text + "'");
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    med_nametxt.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNum.Text= ds.Tables[0].Rows[0][3].ToString();
                    MFG_date.Text= ds.Tables[0].Rows[0][4].ToString();
                    exp_date.Text= ds.Tables[0].Rows[0][5].ToString();
                    txt_AVL_QTY.Text=ds.Tables[0].Rows[0][6].ToString();
                    TXT_PPU.Text= ds.Tables[0].Rows[0][7].ToString();
                    TxtMedicalName.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("This Medicine ID dose'nt Exist: " + txtSearchMed.Text + " Exit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void txtSearchMed_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            txtSearchMed.Clear();
            med_nametxt.Clear();
            txtMedNum.Clear();
            MFG_date.ResetText();
            exp_date.ResetText();
            txt_AVL_QTY.Clear();
            TxtMedicalName.SelectedIndex = -1;
            TXT_PPU.Clear();


            if (txt_qty.Text!="0")
            {
                txt_qty.Text = "0";
            }
            else
            {
                txt_qty.Text = "0";
            }
            txt_qty.Clear();
        }

        Int64 totqty;
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //try
            //{


                if (txtSearchMed.Text.All(char.IsDigit) && txt_AVL_QTY.Text.All(char.IsDigit) && TXT_PPU.Text.All(char.IsDigit) && txtMedNum.Text.All(char.IsDigit) && txt_qty.Text.All(char.IsDigit))
                {
                string mid1 = txtSearchMed.Text;
                string mname = med_nametxt.Text;
                string mnumber = txtMedNum.Text;
                string mdate = MFG_date.Text;
                string edate = exp_date.Text;
                string MedicalName = TxtMedicalName.Text;
                Int64 quantity = Int64.Parse(txt_AVL_QTY.Text);
                Int64 Add_qty = Int64.Parse(txt_qty.Text);
                Int64 perprice = Int64.Parse(TXT_PPU.Text);
                totqty = quantity + Add_qty;

                PharmacistOperations A1 = new PharmacistOperations();
                    A1.UpdateMedicine(mid1,mname,mnumber,mdate,edate,totqty,perprice,MedicalName);
                    MessageBox.Show("Medicine has been Update Successfully", "Medicine Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("The program isn't responding due to incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //query = ("UPDATE pht set mname='" + mname + "',mnumber='" + mnumber + "',mDate='" + mdate + "',eDate='" + edate + "',quantity='" + totqty + "',perUnit='" + perprice + "',MedicalStore='" + MedicalName+"' WHERE mid = '" + txtSearchMed.Text + "'");
                //fn.setData(query, "Medicine Detail Updated.");
            //}
            //catch (Exception exp)
            //{

            //    MessageBox.Show(exp.Message);
            //}


        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UPD_Med_Load(object sender, EventArgs e)
        {

        }

        private void Med_ID_Click(object sender, EventArgs e)
        {

        }

        private void qty_Click(object sender, EventArgs e)
        {

        }
    }
}
