using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using DAL;

namespace BLL
{
    public class Clerkregistration_BLL
    {
        public int clerkregistraion(Clerkregistration_BEL objclerkregBEL)
        {

            Clerkregistration_DAL objclerkregDAL = new Clerkregistration_DAL();

            try
            {
                return objclerkregDAL.Clerkregistration(objclerkregBEL);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //objclerkregDAL = null;
            }

        }
    }
}
