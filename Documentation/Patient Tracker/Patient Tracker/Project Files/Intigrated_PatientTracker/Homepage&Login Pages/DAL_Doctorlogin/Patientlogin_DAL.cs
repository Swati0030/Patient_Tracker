using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class Patientlogin_DAL
    {
       public int Patientlogin(Patientlogin_BEL ploginbel) 
       {
       int result = 0;
       //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
        SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
        
            SqlCommand cmd = new SqlCommand("clerklogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userid", ploginbel.Userid);
            cmd.Parameters.AddWithValue("@password", ploginbel.Password);
            cmd.Parameters.AddWithValue("@usertype", ploginbel.UserType);
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
