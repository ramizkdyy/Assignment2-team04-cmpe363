using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Assignment2
{
    public partial class Default : System.Web.UI.Page
    {
       

        private SqlConnection GetConnection()
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            connection.Open();
            return connection;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblEmployee", connection);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Label1.Text += reader.GetString(reader.GetOrdinal("EmpName")) + " " + reader.GetString(reader.GetOrdinal("EmpSurname")) + " " + reader.GetString(reader.GetOrdinal("EmpAddress")) + " " + reader.GetString(reader.GetOrdinal("EmpPhone")) + "<br>";
                   
                }
             
                reader.Close();
                connection.Close();
            }
            
        }

    }
}