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
    public class BillGeneration_DAL
    {
        int result = 0;
       SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
       //SqlConnection con = new SqlConnection("Data Source=PC180157\\SQLEXPRESS; initial catalog=PatientTracker; User Id=sa; Password=password-1");
       public int patientid(BillGeneration_BEL belbgen)
       {
           SqlCommand cmd = new SqlCommand("findpatientid", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@patientid", belbgen.Patientid);
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
           {
               belbgen.Doctorname = dr[0].ToString();
               belbgen.Consultationdate = dr[1].ToString();
               belbgen.Prescriptionnumber = dr[2].ToString();
               belbgen.Doctorid = dr[3].ToString();
               belbgen.Dateofprescription = dr[4].ToString();
               belbgen.Medicineid = dr[5].ToString();
               belbgen.Patientnumber = dr[6].ToString();
               belbgen.Quantocon = dr[7].ToString();
               belbgen.Nextconsuldate = dr[8].ToString();
               dr.Close();
               cmd.Dispose();
               return 1;
           }
           else {

               return 0;
           }
       }
        public int billgenaration(BillGeneration_BEL belbgen)
        {
            SqlCommand cmd = new SqlCommand("createmedicinebill", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patientid", belbgen.Patientid);
            cmd.Parameters.AddWithValue("@doctorid",belbgen.Doctorid);
            cmd.Parameters.AddWithValue("@doctorname",belbgen.Doctorname);
            cmd.Parameters.AddWithValue("@consultationdate",belbgen.Consultationdate);
            cmd.Parameters.AddWithValue("@prescriptionmunber",belbgen.Prescriptionnumber);
            cmd.Parameters.AddWithValue("@dateofpres",belbgen.Dateofprescription);
            cmd.Parameters.AddWithValue("@medicineid",belbgen.Medicineid);
            cmd.Parameters.AddWithValue("@patientnumber",belbgen.Patientnumber);
            cmd.Parameters.AddWithValue("@quanttocon",belbgen.Quantocon);
            cmd.Parameters.AddWithValue("@consultationfee",belbgen.Consulfee);
            cmd.Parameters.AddWithValue("@medicinebill",belbgen.Medicinefee);
            cmd.Parameters.AddWithValue("@toatlcost",belbgen.Totalcost);
            cmd.Parameters.AddWithValue("@paymentmode",belbgen.Paymentmode);
            cmd.Parameters.AddWithValue("@ccnumber",belbgen.Ccnumber);
            cmd.Parameters.AddWithValue("@isbillpaid",belbgen.Isbillpaid);
            cmd.Parameters.AddWithValue("@nextconsuldate", belbgen.Nextconsuldate);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }


    }
}
