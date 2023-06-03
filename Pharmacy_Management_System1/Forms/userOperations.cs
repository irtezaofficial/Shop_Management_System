using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Pharmacy_Management_System1
{
    class userOperations
    {
        protected void AddUser(string user_role,string name,string dob,string contact,string email,string user,string password)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "insert into AddUser(user_role,u_name,dob,contact,email,us_name,us_password) values ('"+user_role+"','"+name+"','"+dob+"','"+contact+"','"+email+"','"+user+"','"+password+"')";
            SqlCommand cmd = new SqlCommand(query,cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        protected DataTable SearchUser(string txtSearch)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "select * from Adduser where u_name like '%' +'" + txtSearch + "'+ '%'";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cn.Open();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        protected DataTable ViewUser()
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "select * from Adduser";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cn.Open();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        protected void DeleteUser(string user_name)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "delete from AddUser where u_name = '"+user_name+"'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        protected void UpdateUser(string user_role,string u_name,string dob,string contact,string email,string us_name,string us_password)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "update Adduser set user_role = '"+user_role+"', dob = '"+dob+"', contact = '"+contact+"', email = '"+email+"',us_name = '"+us_name+"',us_password = '"+us_password+"' where u_name = '"+u_name+"'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        //public void AddMed(string mid, string mname, string mnumber, string mDate, string eDate, long quantity, long perUnit,string MedicalStore )
        //{
        //    string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
        //    SqlConnection cn = new SqlConnection(connection_string);
        //    string query = "insert into pht(mid,mname ,mnumber,mDate ,eDate,quantity ,perUnit,MedicalStore ) values ('" + mid + "','" + mname+ "','" + mnumber+ "','" + mDate+ "','" + eDate+ "','" + quantity+ "','" + perUnit+ "','"+MedicalStore+"')";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //}
        //public void DeleteMedicine(string Medi_ID)
        //{
        //    //string medicineID;
        //    //medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
        //    SqlConnection cn = new SqlConnection(connection_string);
        //    string query = "delete from pht where mid = '" + Medi_ID + "'";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //}
        //public DataTable ViewMedicine()
        //{
        //    string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
        //    SqlConnection cn = new SqlConnection(connection_string);
        //    string query = "select * from pht";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    cn.Open();
        //    adapter.Fill(dt);
        //    cn.Close();
        //    return dt;
        //}
        //public void UpdateMedicine(string mid,string mname,string mnumber ,string mDate, string Edate, long Quantity, long perUnit, string medicalStore)
        //{
        //    string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
        //    SqlConnection cn = new SqlConnection(connection_string);
        //    string query = "update pht set mname = '" + mname + "', mnumber = '" + mnumber+ "',mDate = '" + mDate + "',eDate = '" + Edate + "',quantity = '" + Quantity + "',perUnit='"+perUnit+ "',MedicalStore='"+medicalStore+"' where mid = '" + mid+ "'";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cn.Open();
        //    cmd.ExecuteNonQuery();
        //}
    }
}
