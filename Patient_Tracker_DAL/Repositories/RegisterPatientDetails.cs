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
using System.Linq.Expressions;

namespace Patient_Tracker_DAL.Repositories
{
    public class RegisterPatientDetails : IPatientRegisterDetail
    {
        private readonly string connectionString;
        public RegisterPatientDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<patient_details> GetDetailsPatient()
        {
            try
            {


                List<patient_details> list = new List<patient_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetDetailsPatient", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    patient_details obj = new patient_details();
                    obj.Patient_No = dt.Rows[i]["Patient_No"].ToString();
                    obj.Patient_Name = dt.Rows[i]["Patient_Name"].ToString();
                    obj.age = int.Parse(dt.Rows[i]["age"].ToString());
                    obj.Address = dt.Rows[i]["Address"].ToString();
                    obj.Contact_No = long.Parse(dt.Rows[i]["Contact_No"].ToString());
                    obj.Gender = dt.Rows[i]["Gender"].ToString();
                    obj.Email_Id = dt.Rows[i]["Email_Id"].ToString();

                    list.Add(obj);
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public patient_details AddPatient(patient_details obj)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {



                    using (SqlCommand cmd = new SqlCommand("AddPatient", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Patient_No", obj.Patient_No);
                        cmd.Parameters.AddWithValue("@Patient_Name", obj.Patient_Name);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
                        cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                        cmd.Parameters.AddWithValue("@Contact_No", obj.Contact_No);
                        cmd.Parameters.AddWithValue("@Email_Id", obj.Email_Id);


                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }




                }
                return obj;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public patient_details UpdatePatient(patient_details obj)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {



                    using (SqlCommand cmd = new SqlCommand("UpdatePatient", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Patient_No", obj.Patient_No);
                        cmd.Parameters.AddWithValue("@Patient_Name", obj.Patient_Name);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
                        cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                        cmd.Parameters.AddWithValue("@Contact_No", obj.Contact_No);
                        cmd.Parameters.AddWithValue("@Email_Id", obj.Email_Id);


                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }




                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }

        }


       
        }
    }

