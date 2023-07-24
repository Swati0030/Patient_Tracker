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
using Patient_Tracker_DAL.Models;

namespace Patient_Tracker_DAL.Repositories
{
    public class ClerkMedicineDetails : IClerkMedicineDetails
    {
        private readonly string connectionString;
        public ClerkMedicineDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<medicine_details> GetDetailsMedicine()
        {
            List<medicine_details> list = new List<medicine_details>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailsMedicine", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            medicine_details obj = new medicine_details();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.medicine_name = reader["medicine_name"].ToString();
                            obj.company_name = reader["company_name"].ToString();
                            obj.medicine_type = reader["medicine_type"].ToString();
                            obj.storage_type = reader["storage_type"].ToString();
                            obj.quantity = int.Parse(reader["quantity"].ToString());
                            obj.price_per_unit = int.Parse(reader["price_per_unit"].ToString());
                            obj.manufacture_date = DateTime.Parse(reader["manufacture_date"].ToString());
                            obj.expiry_date = DateTime.Parse(reader["expiry_date"].ToString());
                            obj.doctor_id = reader["doctor_id"].ToString();

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

        public List<medicine_details> GetDetailsMedicinebyid(string medicine_id)
        {
            List<medicine_details> list = new List<medicine_details>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailsMedicinebyid", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@medicine_id", medicine_id);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if the SqlDataReader contains any rows
                        if (!reader.HasRows)
                        {
                            // If no rows are found with the given medicine_id, return an empty list or handle it accordingly
                            return list;
                        }

                        while (reader.Read())
                        {
                            medicine_details obj = new medicine_details();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.medicine_name = reader["medicine_name"].ToString();
                            obj.company_name = reader["company_name"].ToString();
                            obj.medicine_type = reader["medicine_type"].ToString();
                            obj.storage_type = reader["storage_type"].ToString();
                            obj.quantity = int.Parse(reader["quantity"].ToString());
                            obj.price_per_unit = int.Parse(reader["price_per_unit"].ToString());
                            obj.manufacture_date = DateTime.Parse(reader["manufacture_date"].ToString());
                            obj.expiry_date = DateTime.Parse(reader["expiry_date"].ToString());
                            obj.doctor_id = reader["doctor_id"].ToString();

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



        public medicine_details SaveMedicineDetails(medicine_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the medicine_id already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("CheckMedicineId", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                        checkCmd.CommandType = CommandType.StoredProcedure;
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the medicine_id already exists, display a message or handle it accordingly
                            throw new Exception("Medicine with the given ID already exists.");
                        }
                    }

                    // If the medicine_id does not exist, proceed with inserting the record
                    using (SqlCommand cmd = new SqlCommand("SaveMedicineDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                        cmd.Parameters.AddWithValue("@medicine_name", obj.medicine_name);
                        cmd.Parameters.AddWithValue("@company_name", obj.company_name);
                        cmd.Parameters.AddWithValue("@medicine_type", obj.medicine_type);
                        cmd.Parameters.AddWithValue("@storage_type", obj.storage_type);
                        cmd.Parameters.AddWithValue("@quantity", obj.quantity);
                        cmd.Parameters.AddWithValue("@price_per_unit", obj.price_per_unit);
                        cmd.Parameters.AddWithValue("@manufacture_date", obj.manufacture_date);
                        cmd.Parameters.AddWithValue("@expiry_date", obj.expiry_date);
                        cmd.Parameters.AddWithValue("@doctor_id", obj.doctor_id);

                        // Add other parameters as needed

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



       

        public medicine_details UpdateMedicineDetails(medicine_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    // Check if the medicine with the given medicine_id exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckMedicineId", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                        int existingMedicineCount = (int)checkCommand.ExecuteScalar();



                        if (existingMedicineCount > 0)
                        {
                            // The medicine exists in the database, proceed with the update
                            using (SqlCommand cmd = new SqlCommand("UpdateMedicineDetails", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                                cmd.Parameters.AddWithValue("@medicine_name", obj.medicine_name);
                                cmd.Parameters.AddWithValue("@company_name", obj.company_name);
                                cmd.Parameters.AddWithValue("@medicine_type", obj.medicine_type);
                                cmd.Parameters.AddWithValue("@storage_type", obj.storage_type);
                                cmd.Parameters.AddWithValue("@quantity", obj.quantity);
                                cmd.Parameters.AddWithValue("@price_per_unit", obj.price_per_unit);
                                cmd.Parameters.AddWithValue("@manufacture_date", obj.manufacture_date);
                                cmd.Parameters.AddWithValue("@expiry_date", obj.expiry_date);
                                cmd.Parameters.AddWithValue("@doctor_id", obj.doctor_id);



                                cmd.ExecuteNonQuery();
                            }



                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The medicine with the given medicine_id does not exist in the database.
                            // You can handle this situation by throwing an exception or returning null, depending on your requirements.
                            // For example, you can throw an exception like this:
                            throw new Exception("Medicine with the specified medicine ID does not exist in the database.");
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
    

