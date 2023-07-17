using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Doctor
{
    public interface IServiceDoctorAddPrescription
    {
        public List<prescription_details> GetPrescriptionDetails();
        public List<prescription_details> GetPrescriptionDetailsid(string patient_id);

        public prescription_details SavePrescriptionDetails(prescription_details obj);

        public prescription_details UpdatePrescriptionDetails(prescription_details obj);

     
    }
}
