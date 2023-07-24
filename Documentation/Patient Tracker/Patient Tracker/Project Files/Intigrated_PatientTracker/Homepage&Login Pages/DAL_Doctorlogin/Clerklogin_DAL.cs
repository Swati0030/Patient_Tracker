using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BEL;
using System.Configuration;

namespace DAL
{
    public class Clerklogin_DAL
    {
        int result = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
       // SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
        public int Clerklogin(Clerklogin_BEL belclogin)
        {
            SqlCommand cmd = new SqlCommand("clerklogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userid", belclogin.UserId);
            cmd.Parameters.AddWithValue("@password", belclogin._Pass);
            cmd.Parameters.AddWithValue("@usertype", belclogin.UserType);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            result = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            return result;
        }
    }
}
