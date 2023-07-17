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
    public class DoctorAddPrescriptionDetails : IDoctorAddPrescription
    {
        private readonly string connectionString;
        public DoctorAddPrescriptionDetails(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<prescription_details> GetPrescriptionDetails()
        {
            try
            {


                List<prescription_details> list = new List<prescription_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetPrescriptionDetails", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    prescription_details obj = new prescription_details();
                    obj.prescription_id = (dt.Rows[i]["prescription_id"].ToString());
                    obj.prescription_date = DateTime.Parse(dt.Rows[i]["prescription_date"].ToString());
                    obj.doctor_id = (dt.Rows[i]["doctor_id"].ToString());
                    obj.patient_No = (dt.Rows[i]["patient_No"].ToString());
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.problem_description = (dt.Rows[i]["problem_description"].ToString());
                    obj.prescribed_medicine_name = (dt.Rows[i]["prescribed_medicine_name"].ToString());
                    obj.alternative_medicine_name = (dt.Rows[i]["alternative_medicine_name"].ToString());
                    obj.quantity_to_purchase = int.Parse(dt.Rows[i]["quantity_to_purchase"].ToString());
                    obj.dosage = int.Parse(dt.Rows[i]["dosage"].ToString());
                    obj.duration = (dt.Rows[i]["duration"].ToString());
                    obj.add_note = (dt.Rows[i]["add_note"].ToString());
                    obj.next_consaltation_date = DateTime.Parse(dt.Rows[i]["next_consaltation_date"].ToString());
                    obj.consaltation_id = (dt.Rows[i]["consaltation_id"].ToString());
                    obj.patient_id = (dt.Rows[i]["patient_id"].ToString());
                    obj.medicine_bill_cc_number = int.Parse(dt.Rows[i]["medicine_bill_cc_number"].ToString());


                    list.Add(obj);


                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<prescription_details> GetPrescriptionDetailsid(string patient_id)
        {
            try
            {


                List<prescription_details> list = new List<prescription_details>();
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetPrescriptionDetailsid", con);
               cmd.Parameters.AddWithValue("@patient_id", patient_id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    prescription_details obj = new prescription_details();
                    obj.prescription_id = (dt.Rows[i]["prescription_id"].ToString());
                    obj.prescription_date = DateTime.Parse(dt.Rows[i]["prescription_date"].ToString());
                    obj.doctor_id = (dt.Rows[i]["doctor_id"].ToString());
                    obj.patient_No = (dt.Rows[i]["patient_No"].ToString());
                    obj.medicine_id = (dt.Rows[i]["medicine_id"].ToString());
                    obj.problem_description = (dt.Rows[i]["problem_description"].ToString());
                    obj.prescribed_medicine_name = (dt.Rows[i]["prescribed_medicine_name"].ToString());
                    obj.alternative_medicine_name = (dt.Rows[i]["alternative_medicine_name"].ToString());
                    obj.quantity_to_purchase = int.Parse(dt.Rows[i]["quantity_to_purchase"].ToString());
                    obj.dosage = int.Parse(dt.Rows[i]["dosage"].ToString());
                    obj.duration = (dt.Rows[i]["duration"].ToString());
                    obj.add_note = (dt.Rows[i]["add_note"].ToString());
                    obj.next_consaltation_date = DateTime.Parse(dt.Rows[i]["next_consaltation_date"].ToString());
                    obj.consaltation_id = (dt.Rows[i]["consaltation_id"].ToString());
                    obj.patient_id = (dt.Rows[i]["patient_id"].ToString());
                    obj.medicine_bill_cc_number = int.Parse(dt.Rows[i]["medicine_bill_cc_number"].ToString());


                    list.Add(obj);


                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public prescription_details SavePrescriptionDetails(prescription_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {



                    using (SqlCommand cmd = new SqlCommand("SavePrescriptionDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
                        cmd.Parameters.AddWithValue("@prescription_date", obj.prescription_date);
                        cmd.Parameters.AddWithValue("@doctor_id", obj.doctor_id);
                        cmd.Parameters.AddWithValue("@patient_No", obj.patient_No);
                        cmd.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                        cmd.Parameters.AddWithValue("@problem_description", obj.problem_description);
                        cmd.Parameters.AddWithValue("@prescribed_medicine_name", obj.prescribed_medicine_name);
                        cmd.Parameters.AddWithValue("@alternative_medicine_name", obj.alternative_medicine_name);
                        cmd.Parameters.AddWithValue("@quantity_to_purchase", obj.quantity_to_purchase);
                        cmd.Parameters.AddWithValue("@dosage", obj.dosage);
                        cmd.Parameters.AddWithValue("@duration", obj.duration);
                        cmd.Parameters.AddWithValue("@add_note", obj.add_note);
                        cmd.Parameters.AddWithValue("@next_consaltation_date", obj.next_consaltation_date);
                        cmd.Parameters.AddWithValue("@consaltation_id", obj.consaltation_id);
                        cmd.Parameters.AddWithValue("@patient_id", obj.patient_id);
                        cmd.Parameters.AddWithValue("@medicine_bill_cc_number", obj.medicine_bill_cc_number);


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

        public prescription_details UpdatePrescriptionDetails(prescription_details obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("UpdatePrescriptionDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prescription_id", obj.@prescription_id);
                        cmd.Parameters.AddWithValue("@patient_id", obj.patient_id);
                        cmd.Parameters.AddWithValue("@prescription_date", obj.prescription_date);
                        cmd.Parameters.AddWithValue("@doctor_id", obj.doctor_id);
                        cmd.Parameters.AddWithValue("@patient_No", obj.patient_No);
                        cmd.Parameters.AddWithValue("@medicine_id", obj.medicine_id);
                        cmd.Parameters.AddWithValue("@problem_description", obj.problem_description);
                        cmd.Parameters.AddWithValue("@prescribed_medicine_name", obj.prescribed_medicine_name);
                        cmd.Parameters.AddWithValue("@alternative_medicine_name", obj.alternative_medicine_name);
                        cmd.Parameters.AddWithValue("@quantity_to_purchase", obj.quantity_to_purchase);
                        cmd.Parameters.AddWithValue("@dosage", obj.dosage);
                        cmd.Parameters.AddWithValue("@duration", obj.duration);
                        cmd.Parameters.AddWithValue("@add_note", obj.add_note);
                        cmd.Parameters.AddWithValue("@next_consaltation_date", obj.next_consaltation_date);
                        cmd.Parameters.AddWithValue("@consaltation_id", obj.consaltation_id);
                        cmd.Parameters.AddWithValue("@medicine_bill_cc_number", obj.medicine_bill_cc_number);


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

    

