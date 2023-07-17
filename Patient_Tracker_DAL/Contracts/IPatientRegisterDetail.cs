using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Contracts
{
    public interface IPatientRegisterDetail
    {
        public List<patient_details> GetDetailsPatient();

        public patient_details AddPatient(patient_details obj);

        public patient_details UpdatePatient(patient_details obj);

      



    }
}
