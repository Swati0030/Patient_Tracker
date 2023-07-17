using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
    public interface IServiceClerkMedicineDetails
    {
        public List<medicine_details> GetDetailsMedicine();

        public List<medicine_details> GetDetailsMedicinebyid(string medicine_id);

        public medicine_details SaveMedicineDetails(medicine_details obj);

      
        public medicine_details UpdateMedicineDetails(medicine_details obj);

   
    }

}
