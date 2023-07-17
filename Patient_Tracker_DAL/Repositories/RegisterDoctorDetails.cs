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
            try
            {

                List<doctor_details> list = new List<doctor_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetDetailsDoctor", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    doctor_details obj = new doctor_details();
                    obj.doctor_Id = (dt.Rows[i]["doctor_Id"].ToString());
                    obj.doctor_Name = (dt.Rows[i]["doctor_Name"].ToString());
                    obj.age = int.Parse(dt.Rows[i]["age"].ToString());
                    obj.Experience = int.Parse(dt.Rows[i]["Experience"].ToString());
                    obj.Qualification = (dt.Rows[i]["Qualification"].ToString());
                    obj.Address = (dt.Rows[i]["Address"].ToString());
                    obj.Contact_No = long.Parse(dt.Rows[i]["Contact_No"].ToString());
                    obj.Email_Id = (dt.Rows[i]["Email_Id"].ToString());

                    list.Add(obj);


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



                    using (SqlCommand command = new SqlCommand("SaveDoctorDetails", connection))
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


                        connection.Open();
                        command.ExecuteNonQuery();
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


                        connection.Open();
                        command.ExecuteNonQuery();
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
