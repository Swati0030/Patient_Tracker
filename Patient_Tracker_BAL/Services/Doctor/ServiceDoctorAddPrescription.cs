using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Doctor
{
    public class ServiceDoctorAddPrescription : IServiceDoctorAddPrescription
    {
        public readonly IDoctorAddPrescription _idoctoraddpriscription;

        public ServiceDoctorAddPrescription(IDoctorAddPrescription doctoraddpriscription)
        {
            _idoctoraddpriscription = doctoraddpriscription;
        }

        public List<prescription_details> GetPrescriptionDetails()
        {
            try
            {
                return _idoctoraddpriscription.GetPrescriptionDetails().ToList();
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
                return _idoctoraddpriscription.GetPrescriptionDetailsid(patient_id).ToList();
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
                return _idoctoraddpriscription.SavePrescriptionDetails(obj);
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
                return _idoctoraddpriscription.UpdatePrescriptionDetails(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

   

       
    }
}


    


