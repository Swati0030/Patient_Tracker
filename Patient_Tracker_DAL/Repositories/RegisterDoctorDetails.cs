using Microsoft.Extensions.Configuration;
using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Repositories
{
    public class RegisterDoctorDetails : IRegisterDoctorDetails
    {
        private readonly string connectionString;
        public RegisterDoctorDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<doctor_details> GetDetailsDoctor()
        {
            List<doctor_details> list = new List<doctor_details>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailsDoctor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            doctor_details obj = new doctor_details();
                            obj.doctor_Id = reader["doctor_Id"].ToString();
                            obj.doctor_Name = reader["doctor_Name"].ToString();
                            obj.age = Convert.ToInt32(reader["age"]);
                            obj.Experience = Convert.ToInt32(reader["Experience"]);
                            obj.Qualification = reader["Qualification"].ToString();
                            obj.Address = reader["Address"].ToString();
                            obj.Contact_No = Convert.ToInt64(reader["Contact_No"]);
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

        public doctor_details SaveDoctorDetails(doctor_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the doctor_Id already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM doctor_details WHERE doctor_Id = @doctor_Id", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@doctor_Id", obj.doctor_Id);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the doctor_Id already exists, display a message or handle it accordingly
                            throw new Exception("Doctor with the given ID already exists.");
                        }
                    }

                    // If the doctor_Id does not exist, proceed with inserting the record
                    using (SqlCommand cmd = new SqlCommand("SaveDoctorDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doctor_Id", obj.doctor_Id);
                        cmd.Parameters.AddWithValue("@doctor_Name", obj.doctor_Name);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Experience", obj.Experience);
                        cmd.Parameters.AddWithValue("@Qualification", obj.Qualification);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
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
        public doctor_details UpdateDoctorDetails(doctor_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the doctor with the given doctor_Id exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckDoctorsId", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@doctor_Id", obj.doctor_Id);
                        int existingDoctorCount = (int)checkCommand.ExecuteScalar();

                        if (existingDoctorCount > 0)
                        {
                            // The doctor exists in the database, proceed with the update
                            using (SqlCommand command = new SqlCommand("UpdateDoctorDetails", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@doctor_Id", obj.doctor_Id);
                                command.Parameters.AddWithValue("@doctor_Name", obj.doctor_Name);
                                command.Parameters.AddWithValue("@age", obj.age);
                                command.Parameters.AddWithValue("@Experience", obj.Experience);
                                command.Parameters.AddWithValue("@Qualification", obj.Qualification);
                                command.Parameters.AddWithValue("@Address", obj.Address);
                                command.Parameters.AddWithValue("@Contact_No", obj.Contact_No);
                                command.Parameters.AddWithValue("@Email_Id", obj.Email_Id);

                                command.ExecuteNonQuery();
                            }

                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The doctor with the given doctor_Id does not exist in the database.
                            // You can handle this situation by throwing an exception or returning null, depending on your requirements.
                            // For example, you can throw an exception like this:
                            throw new Exception("Doctor with the specified ID does not exist in the database.");
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
