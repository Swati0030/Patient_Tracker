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
            List<prescription_details> list = new List<prescription_details>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetPrescriptionDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            prescription_details obj = new prescription_details();
                            obj.prescription_id = reader["prescription_id"].ToString();
                            obj.prescription_date = DateTime.Parse(reader["prescription_date"].ToString());
                            obj.doctor_id = reader["doctor_id"].ToString();
                            obj.patient_No = reader["patient_No"].ToString();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.problem_description = reader["problem_description"].ToString();
                            obj.prescribed_medicine_name = reader["prescribed_medicine_name"].ToString();
                            obj.alternative_medicine_name = reader["alternative_medicine_name"].ToString();
                            obj.quantity_to_purchase = int.Parse(reader["quantity_to_purchase"].ToString());
                            obj.dosage = int.Parse(reader["dosage"].ToString());
                            obj.duration = reader["duration"].ToString();
                            obj.add_note = reader["add_note"].ToString();
                            obj.next_consaltation_date = DateTime.Parse(reader["next_consaltation_date"].ToString());
                            obj.consaltation_id = reader["consaltation_id"].ToString();
                            obj.patient_id = reader["patient_id"].ToString();
                            obj.medicine_bill_cc_number = int.Parse(reader["medicine_bill_cc_number"].ToString());

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

        public List<prescription_details> GetPrescriptionDetailsid(string patient_id)
        {
            List<prescription_details> list = new List<prescription_details>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Check if patient_id exists in the database

                    using (SqlCommand checkCmd = new SqlCommand("CheckPatientid", con))
                    {
                        checkCmd.Parameters.AddWithValue("@patient_id", patient_id);
                        checkCmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        int rowCount = (int)checkCmd.ExecuteScalar();

                        if (rowCount == 0)
                        {
                            // patient_id does not exist, return an empty list
                            return list;
                        }
                    }
                     // Fetch prescription details for the patient_id
                    SqlCommand cmd = new SqlCommand("GetPrescriptionDetailsid", con);
                    cmd.Parameters.AddWithValue("@patient_id", patient_id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prescription_details obj = new prescription_details();
                            // Populate prescription_details properties from the reader
                                                 
                            obj.prescription_id = reader["prescription_id"].ToString();
                            obj.prescription_date = DateTime.Parse(reader["prescription_date"].ToString());
                            obj.doctor_id = reader["doctor_id"].ToString();
                            obj.patient_No = reader["patient_No"].ToString();
                            obj.medicine_id = reader["medicine_id"].ToString();
                            obj.problem_description = reader["problem_description"].ToString();
                            obj.prescribed_medicine_name = reader["prescribed_medicine_name"].ToString();
                            obj.alternative_medicine_name = reader["alternative_medicine_name"].ToString();
                            obj.quantity_to_purchase = int.Parse(reader["quantity_to_purchase"].ToString());
                            obj.dosage = int.Parse(reader["dosage"].ToString());
                            obj.duration = reader["duration"].ToString();
                            obj.add_note = reader["add_note"].ToString();
                            obj.next_consaltation_date = DateTime.Parse(reader["next_consaltation_date"].ToString());
                            obj.consaltation_id = reader["consaltation_id"].ToString();
                            obj.patient_id = reader["patient_id"].ToString();
                            obj.medicine_bill_cc_number = int.Parse(reader["medicine_bill_cc_number"].ToString());
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


        public prescription_details SavePrescriptionDetails(prescription_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the patient_id already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("CheckPatientid", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@patient_id", obj.patient_id);
                        checkCmd.CommandType = CommandType.StoredProcedure;
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the patient_id already exists, display a message or handle it accordingly
                            throw new Exception("Patient with the given ID already exists.");
                        }
                    }

                    // If the patient_id does not exist, proceed with inserting the record
                    using (SqlCommand cmd = new SqlCommand("SavePrescriptionDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Add other parameters as needed
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
                    connection.Open();

                    // Check if the patient with the given patient_id exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckPatientid", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@patient_id", obj.patient_id);
                        int existingPatientCount = (int)checkCommand.ExecuteScalar();

                        if (existingPatientCount > 0)
                        {
                            // The patient exists in the database, proceed with the update
                            using (SqlCommand cmd = new SqlCommand("UpdatePrescriptionDetails", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
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

                                cmd.ExecuteNonQuery();
                            }

                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The patient with the given patient_id does not exist in the database.
                            
                           throw new Exception("Patient with the specified patient ID does not exist in the database.");
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

    

