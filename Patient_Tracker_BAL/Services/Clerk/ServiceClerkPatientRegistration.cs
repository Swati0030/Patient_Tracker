using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
   public class ServiceClerkPatientRegistration : IServiceClerkPatientRegistration
    {
        public readonly IPatientRegisterDetail _iclerkPatientRegister;

        public ServiceClerkPatientRegistration(IPatientRegisterDetail clerkPatientRegister)
        {
            _iclerkPatientRegister = clerkPatientRegister;
        }




        public List<patient_details> GetDetailsPatient()
        {
            try
            {
                return _iclerkPatientRegister.GetDetailsPatient().ToList();
            }
            catch (Exception)
            {
                throw;

                
            }
        }


        public patient_details AddPatient(patient_details patient_No)
        {
            try
            {
                return _iclerkPatientRegister.AddPatient(patient_No);
            }
            catch (Exception)
            {
                throw;

                
            }
        }
        public patient_details UpdatePatient(patient_details patient_No)
        {
            try
            {
                return _iclerkPatientRegister.UpdatePatient(patient_No);
            }
            catch (Exception)
            {
                throw;

                
            }
        }
        




    }




}

    

