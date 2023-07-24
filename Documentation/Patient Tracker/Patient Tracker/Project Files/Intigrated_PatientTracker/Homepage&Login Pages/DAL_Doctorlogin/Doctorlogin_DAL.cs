using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Doctorlogin_DAL
    {
        int result = 0;
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
        SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
        public int Doctorlogin(Doctorlogin_BEL beldlogin)
        {
            SqlCommand cmd = new SqlCommand("clerklogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userid", beldlogin.Userid);
            cmd.Parameters.AddWithValue("@password", beldlogin.Password);
            cmd.Parameters.AddWithValue("@usertype", beldlogin.UserType);
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
