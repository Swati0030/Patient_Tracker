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
            List<patient_details> list = new List<patient_details>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailsPatient", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient_details obj = new patient_details();
                            obj.Patient_No = reader["Patient_No"].ToString();
                            obj.Patient_Name = reader["Patient_Name"].ToString();
                            obj.age = int.Parse(reader["age"].ToString());
                            obj.Address = reader["Address"].ToString();
                            obj.Contact_No = long.Parse(reader["Contact_No"].ToString());
                            obj.Gender = reader["Gender"].ToString();

                            obj.Email_Id = reader["Email_Id"].ToString();

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

        public patient_details AddPatient(patient_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the Patient_No already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM patient_details WHERE Patient_No = @Patient_No", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Patient_No", obj.Patient_No);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the Patient_No already exists, display a message or handle it accordingly
                            throw new Exception("Patient with the given ID already exists.");
                        }
                    }

                    // If the Patient_No does not exist, proceed with adding the patient details
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
                    connection.Open();

                    // Check if the patient with the given Patient_No exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckPatientNo", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@Patient_No", obj.Patient_No);
                        int existingPatientCount = (int)checkCommand.ExecuteScalar();

                        if (existingPatientCount > 0)
                        {
                            // The patient exists in the database, proceed with the update
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

                                cmd.ExecuteNonQuery();
                            }

                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The patient with the given Patient_No does not exist in the database.
                            // You can handle this situation by throwing an exception or returning null, depending on your requirements.
                            // For example, you can throw an exception like this:
                            throw new Exception("Patient with the specified Patient No does not exist in the database.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
    }

