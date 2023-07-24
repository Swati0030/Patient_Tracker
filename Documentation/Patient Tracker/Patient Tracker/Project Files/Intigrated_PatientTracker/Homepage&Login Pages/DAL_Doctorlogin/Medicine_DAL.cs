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
    public class Medicine_DAL
    {

        public int medicalInv(Medicine_BEL medBel)
        {
            int result=0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PT"].ConnectionString);
            //SqlConnection con = new SqlConnection("Data Source=pc180159\\SQLEXPRESS; initial catalog=tracker; User Id=sa; Password=password-1");
            SqlCommand cmd = new SqlCommand("addmedicinedetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@medicineid", medBel.Medicineid);
            cmd.Parameters.AddWithValue("@doctorid", medBel.Doctorid);
            cmd.Parameters.AddWithValue("@companyname", medBel.Companyname);
            cmd.Parameters.AddWithValue("@manufacturedate", medBel.Manufacturingdate);
            cmd.Parameters.AddWithValue("@medicinename", medBel.Medicinename);
            cmd.Parameters.AddWithValue("@medicinetype", medBel.Medicinetype);
            cmd.Parameters.AddWithValue("@ppunit", medBel.Priceperunit);
            cmd.Parameters.AddWithValue("@quantity", medBel.Quantity);
            cmd.Parameters.AddWithValue("@storagetype", medBel.Storagetype);
            cmd.Parameters.AddWithValue("@expirydate", medBel.Expirydate);
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
