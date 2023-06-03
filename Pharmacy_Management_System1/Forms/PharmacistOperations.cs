using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy_Management_System1
{
    class PharmacistOperations
    {
        public void AddMed(string mid, string mname, string mnumber, string mDate, string eDate, long quantity, long perUnit, string MedicalStore)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "insert into pht(mid,mname ,mnumber,mDate ,eDate,quantity ,perUnit,MedicalStore ) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "','" + quantity + "','" + perUnit + "','" + MedicalStore + "')";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteMedicine(string Medi_ID)
        {
            //string medicineID;
            //medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "delete from pht where mid = '" + Medi_ID + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        public DataTable ViewMedicine()
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "select * from pht";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cn.Open();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public void UpdateMedicine(string mid, string mname, string mnumber, string mDate, string Edate, long Quantity, long perUnit, string medicalStore)
        {
            string connection_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=addAmed;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection_string);
            string query = "update pht set mname = '" + mname + "', mnumber = '" + mnumber + "',mDate = '" + mDate + "',eDate = '" + Edate + "',quantity = '" + Quantity + "',perUnit='" + perUnit + "',MedicalStore='" + medicalStore + "' where mid = '" + mid + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
