using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using DAL;
namespace BLL
{
    public class Medicine_BLL
    {
        Medicine_DAL medDal = new Medicine_DAL();
        public int medicalInv(Medicine_BEL medBel){

            try
            {
                return medDal.medicalInv(medBel);

            }
            catch (Exception)
            {
                return 0;

            }
            //finally 
            //{
            //    medDal = null;
            //}
        
        
        }
    }
}
