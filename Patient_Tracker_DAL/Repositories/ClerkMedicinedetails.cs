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
    public class ClerkMedicineDetails : IClerkMedicineDetails
    {
        private readonly string connectionString;
        public ClerkMedicineDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<medicine_details> GetDetailsMedicine()
        {
            try
            {

                List<medicine_details> list = new List<medicine_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetDetailsMedicine", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    medicine_details obj = new medicine_details();
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.medicine_name = (dt.Rows[i]["medicine_name"].ToString());
                    obj.company_name = (dt.Rows[i]["company_name"].ToString());
                    obj.medicine_type = (dt.Rows[i]["medicine_type"].ToString());
                    obj.storage_type = (dt.Rows[i]["storage_type"].ToString());
                    obj.quantity = int.Parse(dt.Rows[i]["quantity"].ToString());

                    obj.price_per_unit = int.Parse(dt.Rows[i]["price_per_unit"].ToString());
                    obj.manufacture_date = DateTime.Parse(dt.Rows[i]["manufacture_date"].ToString());
                    obj.expiry_date = DateTime.Parse(dt.Rows[i]["manufacture_date"].ToString());
                    obj.doctor_id = (dt.Rows[i]["doctor_id"].ToString());

                    list.Add(obj);


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
            try
            {

                List<medicine_details> list = new List<medicine_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetDetailsMedicinebyid", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@medicine_id", medicine_id);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    medicine_details obj = new medicine_details();
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.medicine_name = (dt.Rows[i]["medicine_name"].ToString());
                    obj.company_name = (dt.Rows[i]["company_name"].ToString());
                    obj.medicine_type = (dt.Rows[i]["medicine_type"].ToString());
                    obj.storage_type = (dt.Rows[i]["storage_type"].ToString());
                    obj.quantity = int.Parse(dt.Rows[i]["quantity"].ToString());

                    obj.price_per_unit = int.Parse(dt.Rows[i]["price_per_unit"].ToString());
                    obj.manufacture_date = DateTime.Parse(dt.Rows[i]["manufacture_date"].ToString());
                    obj.expiry_date = DateTime.Parse(dt.Rows[i]["manufacture_date"].ToString());
                    obj.doctor_id = (dt.Rows[i]["doctor_id"].ToString());

                    list.Add(obj);


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
            
        public medicine_details UpdateMedicineDetails(medicine_details obj)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {


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
    

