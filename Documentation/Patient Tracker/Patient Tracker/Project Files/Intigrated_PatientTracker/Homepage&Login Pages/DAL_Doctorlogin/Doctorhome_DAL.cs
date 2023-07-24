using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BEL;

namespace DAL
{
    public class Doctorhome_DAL
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
         SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
         public SqlDataAdapter consulattionhistory_dal(Doctorhome_BEL dhbel)
         {
             SqlCommand cmd = new SqlCommand("consultationhistory", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@patientid", dhbel.Patientid);
             cmd.Parameters.AddWithValue("@doctorid",dhbel.Doctorid);
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlDataAdapter dr = new SqlDataAdapter(cmd);
             con.Close();
             return dr;
         }
         public string consulattionid_dal()
         {
             SqlCommand cmd = new SqlCommand("docpatconsulattionid", con);
             cmd.CommandType = CommandType.StoredProcedure;
               con.Open();
            int r= cmd.ExecuteNonQuery();
            string temp =(string) cmd.ExecuteScalar();

             con.Close();
             return temp;
         }
         public int check_dal(Doctorhome_BEL dhbel)
         {
             //SqlCommand cmd;
             //string str;
             //con.Open();
             //str = "select count(*) from patientdetails where patientid='" +dhbel.Patientid + "'";
             //cmd = new SqlCommand(str, con);
             //int r = (int)cmd.ExecuteScalar();
             //con.Close();
             //return r;
             SqlCommand cmd = new SqlCommand("checkpatient", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@patientid", dhbel.Patientid);
             con.Open();
             int r = (int)cmd.ExecuteScalar();
             con.Close();
             return r;
         }
        public int prescriptionnumber_dal(Doctorhome_BEL dhbel)
         {
             SqlCommand cmd = new SqlCommand("docpatprescriptionid", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@patientid", dhbel.Patientid);
             con.Open();
             int r = (int)cmd.ExecuteScalar();
             con.Close();
             return r;
             //SqlCommand cmd;
             //string str;
             //con.Open();
             //str = "select count(*) from prescriptiondetails where patientid='"+dhbel.Patientid+"'";
             //cmd = new SqlCommand(str, con);
             //int r=(int)cmd.ExecuteScalar();
             //con.Close();
             //return r;
         }
         public int createprescription_dal(Doctorhome_BEL dhbel)
         {
             SqlCommand cmd = new SqlCommand("addprescriptiondetails", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@patientid", dhbel.Patientid);
             cmd.Parameters.AddWithValue("@doctorid", dhbel.Doctorid);
             cmd.Parameters.AddWithValue("@consultationid",dhbel.Consultationid);
             cmd.Parameters.AddWithValue("@nextconsuldate", dhbel.Nextconsultationdate);
             cmd.Parameters.AddWithValue("@prescriptionnumber",dhbel.Prescriptionnumber);
             cmd.Parameters.AddWithValue("@prescriptionid",dhbel.Prescriptionid);
             cmd.Parameters.AddWithValue("@presaltmedicinename",dhbel.Alternatemedicinename);
             cmd.Parameters.AddWithValue("@patientnumber", dhbel.Patientnumber); 
             cmd.Parameters.AddWithValue("@additionalnotes",dhbel.Additionalnotes);
             cmd.Parameters.AddWithValue("@prescriptiondate",dhbel.Prescriptiondate);
             cmd.Parameters.AddWithValue("@quanttopur",dhbel.Quantitytopurchase);
             cmd.Parameters.AddWithValue("@problemdesc",dhbel.Problemdescription);
             cmd.Parameters.AddWithValue("@dosage",dhbel.Dosage);
             cmd.Parameters.AddWithValue("@duration",dhbel.Durationtocontinuemedicine);
             cmd.Parameters.AddWithValue("@presmedicinename",dhbel.Prescribedmedicinename);
             cmd.Parameters.AddWithValue("@consultationdate",dhbel.Consultationdate);

             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             int result = cmd.ExecuteNonQuery();
            
             return result;
         }
         public string getname_dal(Doctorhome_BEL dhbel)
         {
             SqlCommand cmd = new SqlCommand("doctorname", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@doctorid", dhbel.Doctorid);
             con.Open();
            string s = Convert.ToString(cmd.ExecuteScalar());
             con.Close();
             return s;
             //SqlCommand cmd;
             //string str;
             //con.Open();
             //str = "select doctorname from doctormaster where doctorid='" + dhbel.Doctorid + "'";
             //cmd = new SqlCommand(str, con);
             //string r = (string)cmd.ExecuteScalar();
             //con.Close();
             //return r;
         }
    }
}