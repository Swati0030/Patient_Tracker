using Patient_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.Clerk
{
    public interface IServiceClerkDoctorRegistration
    {
        public List<doctor_details> GetDetailsDoctor();
        public doctor_details SaveDoctorDetails(doctor_details obj);

        public doctor_details UpdateDoctorDetails(doctor_details obj);

     
    }
    
}
