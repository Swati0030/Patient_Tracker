using Microsoft.Extensions.Configuration;
using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_Tracker_DAL.Models;

namespace Patient_Tracker_DAL.Repositories
{
    
    public class SaveClerkDetails : IAddClerkDetails
    {
        private readonly string connectionString;
        public SaveClerkDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public Clerk_details  AddClerk(Clerk_details obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SaveClerkDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                        cmd.Parameters.AddWithValue("@Clerk_Name ", obj.Clerk_Name);
                       cmd.Parameters.AddWithValue("@Password", obj.Password);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
                        cmd.Parameters.AddWithValue("@Date_of_Joining", obj.Date_of_Joining);
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


        public Clerk_details UpdateClerk(Clerk_details obj)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    using (SqlCommand cmd = new SqlCommand("UpdateClerkDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                        cmd.Parameters.AddWithValue("@Clerk_Name ", obj.Clerk_Name);
                        cmd.Parameters.AddWithValue("@Password", obj.Password);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
                        cmd.Parameters.AddWithValue("@Date_of_Joining", obj.Date_of_Joining);
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
