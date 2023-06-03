using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy_Management_System1
{
    class Admin: userOperations
    {
        public void Adduser(string user_role, string name, string dob, string contact, string email, string user, string password)
        {
            AddUser(user_role, name, dob, contact, email, user, password);
        }


        public bool LoginSuccessfull(string username,string password)
        {
       
                string connecttion_string = @"Data Source=DESKTOP-JSC3HQ9\SQLEXPRESS;Initial Catalog=PharmacyManagment;Integrated Security=True";
                SqlConnection c1 = new SqlConnection(connecttion_string);
                string query = "select * from  AddUser  where us_name = '" + username + "' AND us_password = '" + password + "'";
                SqlCommand command = new SqlCommand(query, c1);
                c1.Open();
                SqlDataReader d1 = command.ExecuteReader();
                return d1.Read();


        }
        public DataTable SearchUsers(string txtSearch)
        {
            return SearchUser(txtSearch);
        }
        public void DeleteUsers(string u_name)
        {
            DeleteUser(u_name);
        }
        public void UpdateUsers(string user_role, string u_name, string dob, string contact, string email, string us_name, string us_password)
        {
            UpdateUser(user_role,u_name, dob, contact, email,us_name, us_password);
        }
        public DataTable ViewUsers()
        {
            return ViewUser();
        }
    }
}
