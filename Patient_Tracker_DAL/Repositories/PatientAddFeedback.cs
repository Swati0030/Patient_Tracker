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


        public feedback_details UpdateFeedbackDetails(feedback_details obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

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
