using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
    public class ServiceAddMedicineDetails : IServiceClerkMedicineDetails
    {
        public readonly IClerkMedicineDetails _iclerkMedicineDetails;

        public ServiceAddMedicineDetails(IClerkMedicineDetails clerkMedicineDetails)
        {
            _iclerkMedicineDetails = clerkMedicineDetails;
        }

        public List<medicine_details> GetDetailsMedicine()
        {
            try
            {
                return _iclerkMedicineDetails.GetDetailsMedicine().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<medicine_details> GetDetailsMedicinebyid(string medicine_id)
        {
            try
            {
                return _iclerkMedicineDetails.GetDetailsMedicinebyid(medicine_id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public medicine_details SaveMedicineDetails(medicine_details obj)
        {
            try
            {
                return _iclerkMedicineDetails.SaveMedicineDetails(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public medicine_details UpdateMedicineDetails(medicine_details obj)
        {
            try
            {
                return _iclerkMedicineDetails.UpdateMedicineDetails(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

       


    }
}
    


