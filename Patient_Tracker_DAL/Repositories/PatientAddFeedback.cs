using Microsoft.Extensions.Configuration;
using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using patienttracker.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Repositories
{
    public class PatientAddFeedback : IPatientAddFeedback
    {
        private readonly string connectionString;
        public PatientAddFeedback(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public feedback_details SaveFeedbackDetails(feedback_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the prescription_id already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM feedback_details WHERE prescription_id = @prescription_id", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If the prescription_id already exists, display a message or handle it accordingly
                            throw new Exception("Feedback with the given prescription ID already exists.");
                        }
                    }

                    // If the prescription_id does not exist, proceed with saving the feedback details
                    using (SqlCommand cmd = new SqlCommand("SaveFeedbackDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
                        cmd.Parameters.AddWithValue("@consultation_date", obj.consultation_date);
                        cmd.Parameters.AddWithValue("@doctor_name", obj.doctor_name);
                        cmd.Parameters.AddWithValue("@problem_description", obj.problem_description);
                        cmd.Parameters.AddWithValue("@additional_notes", obj.additional_notes);
                        cmd.Parameters.AddWithValue("@feedback_detailscol", obj.feedback_detailscol);
                        cmd.Parameters.AddWithValue("@prescription_details_patient_id", obj.prescription_details_patient_id);


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


        public feedback_details UpdateFeedbackDetails(feedback_details obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the feedback with the given prescription_id exists in the database
                    using (SqlCommand checkCommand = new SqlCommand("CheckPrescriptionDetails", connection))
                    {
                        checkCommand.CommandType = CommandType.StoredProcedure;
                        checkCommand.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
                        int existingFeedbackCount = (int)checkCommand.ExecuteScalar();

                        if (existingFeedbackCount > 0)
                        {
                            // The feedback exists in the database, proceed with the update
                            using (SqlCommand cmd = new SqlCommand("UpdateFeedbackDetails", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@prescription_id", obj.prescription_id);
                                cmd.Parameters.AddWithValue("@consultation_date", obj.consultation_date);
                                cmd.Parameters.AddWithValue("@doctor_name", obj.doctor_name);
                                cmd.Parameters.AddWithValue("@problem_description", obj.problem_description);
                                cmd.Parameters.AddWithValue("@additional_notes", obj.additional_notes);
                                cmd.Parameters.AddWithValue("@feedback_detailscol", obj.feedback_detailscol);
                                cmd.Parameters.AddWithValue("@prescription_details_patient_id", obj.prescription_details_patient_id);

                                cmd.ExecuteNonQuery();
                            }

                            // Return the updated object
                            return obj;
                        }
                        else
                        {
                            // The feedback with the given prescription_id does not exist in the database.
                            // You can handle this situation by throwing an exception or returning null, depending on your requirements.
                            // For example, you can throw an exception like this:
                            throw new Exception("Feedback with the specified prescription ID does not exist in the database.");
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
