using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Patient_Tracker_DAL.Repositories
{
    public class ClerkGenerateMedicineBills : IClerkGenerateMedicineBills
    {
        private readonly string connectionString;
        public ClerkGenerateMedicineBills(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<medicine_bill> GetMedicineBills()
        {
            try
            {
                List<medicine_bill> list = new List<medicine_bill>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetMedicineBills", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    medicine_bill obj = new medicine_bill();
                    obj.Cc_Number = int.Parse(dt.Rows[i]["Cc_Number"].ToString());
                    obj.doctor_Id = (dt.Rows[i]["doctor_Id"].ToString());
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.date_of_prescription = DateTime.Parse(dt.Rows[i]["date_of_prescription"].ToString());
                    obj.consul_date = DateTime.Parse(dt.Rows[i]["consul_date"].ToString());
                    obj.patient_id = (dt.Rows[i]["patient_id"].ToString());
                    obj.doctor_name = (dt.Rows[i]["doctor_name"].ToString());
                    obj.prescription_id = (dt.Rows[i]["prescription_id"].ToString());
                    obj.Patient_No = (dt.Rows[i]["Patient_No"].ToString());



                    list.Add(obj);


                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<medicine_bill> GetMedicineByCcNumber(int ccNumber)
        {
            try
            {


                List<medicine_bill> list = new List<medicine_bill>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetMedicineByCcNumber", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ccNumber", ccNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    medicine_bill obj = new medicine_bill();
                    obj.Cc_Number = int.Parse(dt.Rows[i]["Cc_Number"].ToString());
                    obj.doctor_Id = (dt.Rows[i]["doctor_Id"].ToString());
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.date_of_prescription = DateTime.Parse(dt.Rows[i]["date_of_prescription"].ToString());
                    obj.consul_date = DateTime.Parse(dt.Rows[i]["consul_date"].ToString());
                    obj.patient_id = (dt.Rows[i]["patient_id"].ToString());
                    obj.doctor_name = (dt.Rows[i]["doctor_name"].ToString());
                    obj.prescription_id = (dt.Rows[i]["prescription_id"].ToString());
                    obj.Patient_No = (dt.Rows[i]["Patient_No"].ToString());

                    list.Add(obj);
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }

        }
       
    }






}
    

 