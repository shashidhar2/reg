using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace register.Models
{
    public class reglayer
    {
        String Connection = "Data Source=LAKSHMI\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True";
        public void AddEmployee(registermodels employee)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                SqlCommand cmd = new SqlCommand("ins", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@password", employee.password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}