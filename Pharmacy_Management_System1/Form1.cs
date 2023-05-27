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
    public partial class Form1 : Form
    {
        Function2 f2 = new Function2();
        string query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswordss.Clear();

        }


        private void btnSignin_Click(object sender, EventArgs e)
        {

            query = "Select * from AddUser";
            ds = f2.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "Minhal" && txtPasswordss.Text == "Raza")
                {
                    Administrator A1 = new Administrator();
                    A1.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "Select * from AddUser where us_name='" + txtUsername.Text + "'and us_password='" + txtPasswordss.Text + "'";

                ds = f2.GetData(query);

                if (ds.Tables[0].Rows.Count != 0)

                {
                    string user_role = ds.Tables[0].Rows[0][0].ToString();


                    if (user_role == "Administrator")
                    {

                        Administrator A1 = new Administrator();
                        A1.Show();
                        this.Hide();

                    }
                    else if (user_role == "Pharmacist")
                    {
                        Pharmasist P1 = new Pharmasist();
                        P1.Show();
                        this.Hide();

                    }

                }
                else
                {
                    MessageBox.Show("Wrong Credentials Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               

            } 

            



                ////if (txtUsername.Text == "" && txtPassword.Text == "")
                ////{
                ////    MessageBox.Show("Username or Password is missing\nEnter User Role", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ////}
                ////else
                ////{
                ////    Admin a1 = new Admin();
                ////    if (a1.LoginSuccessfull(txtUsername.Text, txtPassword.Text) == true)

            //////if
            ////{
            ////    if (Userrole1.Text == "Administrator")
            ////    {
            ////        this.Hide();
            ////        if (v1 == null)
            ////        {
            ////            v1 = new Administrator();
            ////            v1.FormClosed += FormClosed;
            ////            v1.Show();
            ////        }
            ////        else
            ////        {
            ////            v1.Activate();
            ////        }
            ////    }
            ////    if (Userrole1.Text == "Pharmacist")
            ////    {
            ////        v2 = new Pharmasist();
            ////        v2.FormClosed += FormClosed;
            ////        v2.Show();
            ////    }
            //}





            ////else if (a1.LoginSuccessfull(txtUsername.Text, txtPassword.Text) == true && Userrole1.Text== "Pharmacist")
            ////{
            ////    v2 = new Pharmasist();
            ////    v2.FormClosed += FormClosed;
            ////    v2.Show();
            ////}
            ////else
            ////{
            ////    MessageBox.Show("Username Or Password is incorrect", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}


        }
        //void FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    v1= null;
        //}
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.Show();
            this.Hide();
        }

        private void Userrole1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Pharmacist_Login PL = new Pharmacist_Login();
            //PL.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
