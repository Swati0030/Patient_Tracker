using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_PatientRegistration;
using BEL_PatientRegistration;

namespace BLL_PatientRegistration
{
    public class PatientRegistration_BLL
    {
        PatientRegistration_DAL dalpregistration = new PatientRegistration_DAL();
        public int Patientregistration(PatientRegistration_BEL belpregistration)
        {

            try
            {
                return dalpregistration.Patientregistration(belpregistration);
            }
            catch (Exception)
            {
                return -1;
            }           
        }
      
    }
}
