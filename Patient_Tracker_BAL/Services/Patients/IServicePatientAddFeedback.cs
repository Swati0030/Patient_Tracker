﻿using Patient_Tracker.Models;
using patienttracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Patients
{
    public interface IServicePatientAddFeedback
    {
        public feedback_details SaveFeedbackDetails(feedback_details obj);
        public feedback_details UpdateFeedbackDetails(feedback_details obj);

      
    }

}
