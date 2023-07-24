using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL_Docregistration;
using DAL_Docregistration;

namespace BLL_Docregistration
{
    public class Docregistration_BLL
    {
        public int doctorregistration(Docregistration_BEL objdoctorregBEL)
    {
        Docregistration_DAL objdoctorregDAL=new Docregistration_DAL();
        try
        {
            return objdoctorregDAL.Doctorregistration(objdoctorregBEL);
        }
        catch (Exception)
        {
            return -1;
        }       
    }
    }
}
