using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL

{
    public class Clerkregistration_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS ;initial catalog=tracker; User Id=sa; Password=password-1");
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
        public int Clerkregistration(Clerkregistration_BEL objclerkregBEL)
        {
            int result;
            try
            {

                SqlCommand cmd1 = new SqlCommand("addUserdetails", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@userid", objclerkregBEL._clerkid);
                cmd1.Parameters.AddWithValue("@password", objclerkregBEL._password);
                cmd1.Parameters.AddWithValue("@username", objclerkregBEL._clerkname);
                cmd1.Parameters.AddWithValue("@usertype", objclerkregBEL._usertype);
                SqlCommand cmd = new SqlCommand("addClerkdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clerkid", objclerkregBEL._clerkid);
                cmd.Parameters.AddWithValue("@clerkname", objclerkregBEL._clerkname);
                cmd.Parameters.AddWithValue("@age", objclerkregBEL._age);
                cmd.Parameters.AddWithValue("@address", objclerkregBEL._address);
                cmd.Parameters.AddWithValue("@contactnumber", objclerkregBEL._contactnumber);
                cmd.Parameters.AddWithValue("@password", objclerkregBEL._password);
                cmd.Parameters.AddWithValue("@doj", objclerkregBEL._doj);
                cmd.Parameters.AddWithValue("@emailid", objclerkregBEL._emailid);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                
               int result1 = cmd1.ExecuteNonQuery();
               result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd1.Dispose();
                if (result!=0 && result1!=0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }
    }
}
