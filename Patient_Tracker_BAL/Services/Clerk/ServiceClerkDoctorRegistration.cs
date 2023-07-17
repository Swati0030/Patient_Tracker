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
    public class ServiceClerkDoctorRegistration : IServiceClerkDoctorRegistration
    {
        
        public readonly IRegisterDoctorDetails _iclerkDoctorRegistration;

    public ServiceClerkDoctorRegistration(IRegisterDoctorDetails clerkDoctorRegistration)
    {
        _iclerkDoctorRegistration = clerkDoctorRegistration;
    }

    public List<doctor_details> GetDetailsDoctor()
    {
        try
        {
            return _iclerkDoctorRegistration.GetDetailsDoctor().ToList();
        }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured while retriving the doctor details:" + ex.Message);

                return null;
            }
        }


    public doctor_details SaveDoctorDetails(doctor_details obj)
    {
        try
        {
            return _iclerkDoctorRegistration.SaveDoctorDetails(obj);
        }

            catch (Exception)
            {
                throw;
            }

        }
    public doctor_details UpdateDoctorDetails(doctor_details obj)
    {
        try
        {
            return _iclerkDoctorRegistration.UpdateDoctorDetails(obj);
        }
            catch (Exception)
            {

                throw;
                
            }
        }
 




}




}




