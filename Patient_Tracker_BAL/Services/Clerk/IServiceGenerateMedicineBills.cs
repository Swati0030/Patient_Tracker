using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
    public interface IServiceGenerateMedicineBills
    {
        public List<medicine_bill> GetMedicineBills();

        public List<medicine_bill> GetMedicineByCcNumber(int ccNumber);
    }
}
