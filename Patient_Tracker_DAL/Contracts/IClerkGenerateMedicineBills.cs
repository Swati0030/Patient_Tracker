using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Contracts
{
    public interface IClerkGenerateMedicineBills
    {
        public List<medicine_bill> GetMedicineBills();

        public List<medicine_bill> GetMedicineByCcNumber(int ccNumber);


    }
}
