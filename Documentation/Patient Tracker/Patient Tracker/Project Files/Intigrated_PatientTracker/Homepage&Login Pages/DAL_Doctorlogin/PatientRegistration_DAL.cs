using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL_PatientRegistration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL_PatientRegistration
{
    public class PatientRegistration_DAL
    {
        
       // SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
        public int Patientregistration(PatientRegistration_BEL belpregistration)
        {
            int result;

            try
            {

                SqlCommand cmd1 = new SqlCommand("addUserdetails", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@userid", belpregistration.Patientid);
                cmd1.Parameters.AddWithValue("@username", belpregistration.Patientname);
                cmd1.Parameters.AddWithValue("@password", belpregistration.Password);
                cmd1.Parameters.AddWithValue("@usertype", belpregistration.Usertype);

                SqlCommand cmd = new SqlCommand("addpatientdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patientid", belpregistration.Patientid);
                cmd.Parameters.AddWithValue("@patientname", belpregistration.Patientname);
                cmd.Parameters.AddWithValue("@age", belpregistration.Patientage);
                cmd.Parameters.AddWithValue("@address", belpregistration.Patientaddress);
                cmd.Parameters.AddWithValue("@contactnumber", belpregistration.Patientcontactnumber);
                cmd.Parameters.AddWithValue("@emailid", belpregistration.Emailid);
                cmd.Parameters.AddWithValue("@gender", belpregistration.Gender);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                result = cmd1.ExecuteNonQuery();
                int result1 = cmd.ExecuteNonQuery();
                cmd1.Dispose();
                cmd.Dispose();
                if (result != 0 && result1 != 0)
                {
                    return result;
                }
                else
                {
                    result = 0;
                    return result;
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
