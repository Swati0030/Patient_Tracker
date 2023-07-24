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
            List<medicine_bill> list = new List<medicine_bill>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetMedicineBills", con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicine_bill obj = new medicine_bill();
                            obj.Cc_Number = int.Parse(reader["Cc_Number"].ToString());
                            obj.doctor_Id = reader["doctor_Id"].ToString();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.date_of_prescription = DateTime.Parse(reader["date_of_prescription"].ToString());
                            obj.consul_date = DateTime.Parse(reader["consul_date"].ToString());
                            obj.patient_id = reader["patient_id"].ToString();
                            obj.doctor_name = reader["doctor_name"].ToString();
                            obj.prescription_id = reader["prescription_id"].ToString();
                            obj.Patient_No = reader["Patient_No"].ToString();

                            list.Add(obj);
                        }
                    }
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
            List<medicine_bill> list = new List<medicine_bill>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetMedicineByCcNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ccNumber", ccNumber);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            // If no rows are found with the given ccNumber, return an empty list or handle it accordingly
                            Console.WriteLine("The CcNumber does not exists");
                            return list;

                        }

                        while (reader.Read())
                        {
                            medicine_bill obj = new medicine_bill();
                            obj.Cc_Number = int.Parse(reader["Cc_Number"].ToString());
                            obj.doctor_Id = reader["doctor_Id"].ToString();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.date_of_prescription = DateTime.Parse(reader["date_of_prescription"].ToString());
                            obj.consul_date = DateTime.Parse(reader["consul_date"].ToString());
                            obj.patient_id = reader["patient_id"].ToString();
                            obj.doctor_name = reader["doctor_name"].ToString();
                            obj.prescription_id = reader["prescription_id"].ToString();
                            obj.Patient_No = reader["Patient_No"].ToString();

                            list.Add(obj);
                        }
                    }
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
    

 