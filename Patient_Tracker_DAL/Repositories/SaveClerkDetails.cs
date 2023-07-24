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

        public Clerk_details AddClerk(Clerk_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the Clerk_Id already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Clerk_details WHERE Clerk_Id = @Clerk_Id", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the Clerk_Id already exists, display a message or handle it accordingly
                            throw new Exception("Clerk with the given ID already exists.");
                        }
                    }

                    // If the Clerk_Id does not exist, proceed with adding the clerk's details
                    using (SqlCommand cmd = new SqlCommand("SaveClerkDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                        cmd.Parameters.AddWithValue("@Clerk_Name", obj.Clerk_Name);
                        cmd.Parameters.AddWithValue("@Password", obj.Password);
                        cmd.Parameters.AddWithValue("@age", obj.age);
                        cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                        cmd.Parameters.AddWithValue("@Address", obj.Address);
                        cmd.Parameters.AddWithValue("@Date_of_Joining", obj.Date_of_Joining);
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

        public Clerk_details UpdateClerk(Clerk_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the clerk with the given Clerk_Id exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckClerkId", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                        int existingClerkCount = (int)checkCommand.ExecuteScalar();

                        if (existingClerkCount > 0)
                        {
                            // The clerk exists in the database, proceed with the update
                            using (SqlCommand cmd = new SqlCommand("UpdateClerkDetails", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Clerk_Id", obj.Clerk_Id);
                                cmd.Parameters.AddWithValue("@Clerk_Name", obj.Clerk_Name);
                                cmd.Parameters.AddWithValue("@Password", obj.Password);
                                cmd.Parameters.AddWithValue("@age", obj.age);
                                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                                cmd.Parameters.AddWithValue("@Address", obj.Address);
                                cmd.Parameters.AddWithValue("@Date_of_Joining", obj.Date_of_Joining);
                                cmd.Parameters.AddWithValue("@Email_Id", obj.Email_Id);

                                cmd.ExecuteNonQuery();
                            }

                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The clerk with the given Clerk_Id does not exist in the database.
                            // You can handle this situation by throwing an exception or returning null, depending on your requirements.
                            // For example, you can throw an exception like this:
                            throw new Exception("Clerk with the specified Clerk ID does not exist in the database.");
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
