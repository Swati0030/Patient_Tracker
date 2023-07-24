using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BEL;

namespace DAL
{
   public  class Patienthome_DAL
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
       int result = 0;
       SqlConnection con = new SqlConnection("Data Source=PC180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
       public int feedback_dal(Patienthome_BEL phbel)
       {
           SqlCommand cmd = new SqlCommand("patienthome", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@patientid", phbel.Patientid);
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
           {
               phbel.Prescriptionid = dr[0].ToString();
               phbel.Consultationdate = dr[1].ToString();
               phbel.Doctorname = dr[2].ToString();
               phbel.Problemdesc = dr[3].ToString();
               dr.Close();
               cmd.Dispose();
               return 1;
           }
           else
           {
               return 0;
           }
       }
       public int submitfeedback_dal(Patienthome_BEL phbel)
       {
           
           SqlCommand cmd = new SqlCommand("addfeedbackdetails", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@prescriptionid", phbel.Prescriptionid);
           cmd.Parameters.AddWithValue("@consultationdate",phbel.Consultationdate);
           cmd.Parameters.AddWithValue("@doctorname",phbel.Doctorname);
           cmd.Parameters.AddWithValue("@problemdesc",phbel.Problemdesc);
           cmd.Parameters.AddWithValue("@additionalnotes",phbel.Additionalnotes);
           result = cmd.ExecuteNonQuery();
           return result;
       }
       public SqlDataAdapter viewhistory_dal(Patienthome_BEL phbel)
       {
           SqlCommand cmd = new SqlCommand("viewhistory", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@patientid", phbel.Patientid);
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlDataAdapter dr = new SqlDataAdapter(cmd);
           //DataSet ds = new DataSet();
           //dr.Fill(ds);
           con.Close();
           return dr;
       }
       public List<string> ddlist_dal(Patienthome_BEL phbel)
       {
           SqlCommand cmd = new SqlCommand("ddlconsultationid", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@patientid", phbel.Patientid);
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlDataReader dr = cmd.ExecuteReader();
           List<string> dd = new List<string>();
           while (dr.Read())
           {
               dd.Add(dr[0].ToString());
           }
           con.Close();
           return dd;

       }
       public SqlDataAdapter prescriptionscreen_dal(string s)
       {
           SqlCommand cmd = new SqlCommand("prescriptionscreen", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@consultationid", s);
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlDataAdapter dr = new SqlDataAdapter(cmd);
           //DataSet ds = new DataSet();
           //dr.Fill(ds);
           return dr;
       }
       
    }
}
