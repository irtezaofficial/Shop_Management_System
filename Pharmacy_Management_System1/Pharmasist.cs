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
    public partial class Pharmasist : Form
    {
        public Pharmasist()
        {
            InitializeComponent();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            Add_Med AM = new Add_Med();
            AM.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_viewuser_Click(object sender, EventArgs e)
        {
            ViewMed VM = new ViewMed();
            VM.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Sell_Med MS = new Sell_Med();
            MS.Show();
            this.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UPD_Med UM = new UPD_Med();
            UM.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
