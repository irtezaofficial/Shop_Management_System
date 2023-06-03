using DGVPrinterHelper;
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
    public partial class Sell_Med : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Sell_Med()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count>1)
            {
                MessageBox.Show("Please empty your cart to go back", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                Pharmasist f1 = new Pharmasist();
                f1.Show();
                this.Hide();
            }
        }

        private void Sell_Med_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxMedicines.Items.Clear();
                query = "Select mname from pht  where eDate >= getdate() and quantity >'0'";
                ds = fn.GetData(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            //query = "select mname from pht where MedicalStore like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity >'0'";









            query = "select mname from pht Where mname like '" + txtSearch.Text + "%'and eDate >= getdate() and quantity > '0'";
            query += "OR MedicalStore like '" + txtSearch.Text + "%'and eDate >= getdate() and quantity > '0'";
            ds = fn.GetData(query);







            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNoofunits.Clear();

                String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
                txtMediName.Text = name;
                query = "select mid,eDate,perUnit,MedicalStore from pht where mname ='" + name + "'";
                ds = fn.GetData(query);

                txtMediId.Text = ds.Tables[0].Rows[0][0].ToString();
       
                txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
                txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
                TxtMedicalName12.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNoofunits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoofunits.Text !="")
            {
                Int64 Price_Per_Unit = Int64.Parse(txtPricePerUnit.Text);
                Int64 No_of_Units = Int64.Parse(txtNoofunits.Text);
                Int64 totalAmount = Price_Per_Unit * No_of_Units;
                txtTotalPrice.Text = totalAmount.ToString();
            }

            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQunantity;

       
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text!="")
            {
                query= "select quantity from pht where mid='"+txtMediId.Text+"'";
                ds = fn.GetData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQunantity = quantity - Int64.Parse(txtNoofunits.Text);

                if(newQunantity>=0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMediId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoofunits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[6].Value = TxtMedicalName12.Text;


                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "Rs." + totalAmount.ToString();


                    query = "update pht set quantity = '" + newQunantity + "'where mid ='" + txtMediId.Text + "'";
                    fn.setData(query, "Medicine Added.");


                }

                else
                {
                    MessageBox.Show("Medicine is Out of Stock\nQuanity Available is: " + quantity,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                clearAll();

                Sell_Med_Load(this, null);

            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;



        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch (Exception)
            {

               
            }

        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch 
                {

           
                }
                finally
                {
                    query = "Select quantity from pht where mid = '" + valueId + "'";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQunantity = quantity + noOfunit;

                    query = "Update pht set quantity = '" + newQunantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine Removed From Cart");
                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "Rs. " + totalAmount.ToString();
                }
                Sell_Med_Load(this, null);
            }
        }

        private void Dvago_Click(object sender, EventArgs e)
        {
            query = "Select mname from pht where MedicalStore='" + "Dvago" + "'";
            fn.GetData(query);
            MessageBox.Show("submitted");
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Pharmacy Management System";
            print.Title = "Sale Invoice";
            print.SubTitle = "Medicine Bill";
            print.SubTitle = string.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer= "Total Payable Amount is: " + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;




            

        }
        private void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoofunits.Clear();
            TxtMedicalName12.Clear();

        }

    }
}
