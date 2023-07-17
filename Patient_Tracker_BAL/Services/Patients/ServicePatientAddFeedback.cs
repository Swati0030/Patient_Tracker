using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Repositories;
using patienttracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Patients
{
    public class ServicePatientAddFeedback : IServicePatientAddFeedback
    {
        public readonly IPatientAddFeedback _ipatientaddfeedback;

        public ServicePatientAddFeedback(IPatientAddFeedback patientaddfeedback)
        {
            _ipatientaddfeedback = patientaddfeedback;
        }

        public feedback_details SaveFeedbackDetails(feedback_details obj)
        {
            try
            {
                return _ipatientaddfeedback.SaveFeedbackDetails(obj);
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
                return _ipatientaddfeedback.UpdateFeedbackDetails(obj);
            }
            catch (Exception)
            {
                throw;

                
            }
        }

       


    }
}
    


    

