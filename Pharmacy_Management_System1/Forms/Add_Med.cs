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
    public partial class Add_Med : Form
    {
        function fn = new function();
        string query;

        public Add_Med()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pharmasist p1 = new Pharmasist();
            p1.Show();
            this.Hide();
        }

        private void Add_Med_Load(object sender, EventArgs e)
        {



    
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {


            if (txt_mid.Text != " " && txtMedName.Text!=" " && Txt_mednum.Text!=" " && txtMFG_date.Text!=" " && TXT_ED.Text!=" " && txtMedName.Text.All(char.IsLetter) && txtqty.Text.All(char.IsDigit) && txt_ppu.Text.All(char.IsDigit) && Txt_mednum.Text.All(char.IsDigit))
            {
                Int64 quantity = Int64.Parse(txtqty.Text);
                Int64 perUnit = Int64.Parse(txt_ppu.Text);
                PharmacistOperations A1 = new PharmacistOperations();
                A1.AddMed(txt_mid.Text, txtMedName.Text, Txt_mednum.Text, txtMFG_date.Text, TXT_ED.Text, quantity, perUnit, TxtMedicalName.Text);
                MessageBox.Show("Medicine Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Medicine can not be added","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }





            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True");
            //SqlCommand cmd1;
            //try
            //{
            //    if (txt_mid.Text != "" && txtMedName.Text != "" && Txt_mednum.Text != "" && txtMFG_date.Text != "" && TXT_ED.Text != "" && txtqty.Text != "" && txt_ppu.Text != "" && TxtMedicalName.Text != "")
            //    {


            //        string mid = txt_mid.Text;
            //        string mname = txtMedName.Text;
            //        string mnumber = Txt_mednum.Text;
            //        string mDate = txtMFG_date.Text;
            //        string eDate = TXT_ED.Text;
            //        string medicalName = TxtMedicalName.Text;
            //        Int64 quantity = Int64.Parse(txtqty.Text);
            //        Int64 perUnit = Int64.Parse(txt_ppu.Text);
            //        //con.Open();
            //        //query = "INSERT into pht(mid,mname,mnumber,mdate,edate,quantity,perUnit) VALUES('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "','" + quantity + "','" + txt_ppu.Text + ")";
            //        //fn.setData(query, "Medicine added to database.");
            //        con.Open();
            //        cmd1 = new SqlCommand("INSERT into pht(mid,mname,mnumber,mdate,edate,quantity,perUnit,MedicalStore) VALUES('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "','" + quantity + "','" + txt_ppu.Text + "','" + medicalName + "')", con);

            //        cmd1.ExecuteNonQuery();
            //        MessageBox.Show("Medicine added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Insert Data Properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txt_mid_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            txt_mid.Clear();
            txtMedName.Clear();
            Txt_mednum.Clear();
            txtMFG_date.ResetText();
            TXT_ED.ResetText();
            txtqty.Clear();
            txt_ppu.Clear();
            TxtMedicalName.SelectedIndex = -1;
        }

        private void Exp_date_Click(object sender, EventArgs e)
        {

        }

        private void QTY_Click(object sender, EventArgs e)
        {

        }

        private void COM_Click(object sender, EventArgs e)
        {

        }

        private void MedName_Click(object sender, EventArgs e)
        {

        }
    }
}
