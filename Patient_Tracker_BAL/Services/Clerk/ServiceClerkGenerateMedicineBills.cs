using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
    public class ServiceClerkGenerateMedicineBills : IServiceGenerateMedicineBills
    {
        public readonly IClerkGenerateMedicineBills _iclerkGenerateMedicineBills;

        public ServiceClerkGenerateMedicineBills(IClerkGenerateMedicineBills clerkPatientRegister)
        {
            _iclerkGenerateMedicineBills = clerkPatientRegister;
        }

        public List<medicine_bill> GetMedicineBills()
        {
            try
            {
                return _iclerkGenerateMedicineBills.GetMedicineBills().ToList();
            }
            catch (Exception)
            {
                throw;

                
            }
        }

        public List<medicine_bill> GetMedicineByCcNumber(int CcNumber)
        {
            try
            {
                return _iclerkGenerateMedicineBills.GetMedicineByCcNumber(CcNumber).ToList();
            }
            catch (Exception)
            {

                throw;
                
            }
        }



    }
}


    

