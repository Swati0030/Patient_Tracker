using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using DAL;

namespace BLL
{
    public class BillGeneration_BLL
    {
        BillGeneration_DAL bllgendal = new BillGeneration_DAL();
        public int bllpid(BillGeneration_BEL belbgen)
        {
            try
            {
               int i= bllgendal.patientid(belbgen);
               return i;
            }
            catch (Exception)
            {

                throw;
            }
        }
           
        public int bllbgen(BillGeneration_BEL belbgen)
        {
            try
            {
                return bllgendal.billgenaration(belbgen);
            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}
