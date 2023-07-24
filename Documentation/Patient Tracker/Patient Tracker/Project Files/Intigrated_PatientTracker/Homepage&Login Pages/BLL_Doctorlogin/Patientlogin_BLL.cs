using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using DAL;

namespace BLL
{
   public  class Patientlogin_BLL
    {
        public int PatientLogin(Patientlogin_BEL beldlogin)
        {
            Patientlogin_DAL plogindal = new Patientlogin_DAL(); 
            try
            {
                return plogindal.Patientlogin(beldlogin);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
