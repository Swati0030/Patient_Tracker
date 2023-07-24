using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL_Docregistration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Docregistration
{
    public class Docregistration_DAL
    {
        SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS ;initial catalog=tracker; User Id=sa; Password=password-1");
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
        public int Doctorregistration(Docregistration_BEL objdoctorregBEL)
        {
            int result;
            
            try
            {
                SqlCommand cmd1 = new SqlCommand("addUserdetails", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@userid", objdoctorregBEL._doctorid);
                cmd1.Parameters.AddWithValue("@password", objdoctorregBEL._password);
                cmd1.Parameters.AddWithValue("@username", objdoctorregBEL._doctorname);
                cmd1.Parameters.AddWithValue("@usertype", objdoctorregBEL._usertype);



                SqlCommand cmd = new SqlCommand("adddoctordetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doctorid", objdoctorregBEL._doctorid);
                cmd.Parameters.AddWithValue("@doctorname", objdoctorregBEL._doctorname);
                cmd.Parameters.AddWithValue("@qualification", objdoctorregBEL._qualification);
                cmd.Parameters.AddWithValue("@age", objdoctorregBEL._age);
                cmd.Parameters.AddWithValue("@address", objdoctorregBEL._address);
                cmd.Parameters.AddWithValue("@experience", objdoctorregBEL._experience);
                cmd.Parameters.AddWithValue("@contactnumber", objdoctorregBEL._contactnumber);
                cmd.Parameters.AddWithValue("@emailid", objdoctorregBEL._emailid);
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                int result1 = cmd1.ExecuteNonQuery();
                result = cmd.ExecuteNonQuery();                
                cmd.Dispose();
                cmd1.Dispose();
                if (result != 0 && result1!=0)
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
