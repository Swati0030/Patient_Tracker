using Patient_Tracker.Models;
using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.ClerkDetails
{
    public class ServiceClerkDetails : IServiceClerkDetails
    {

        public readonly IAddClerkDetails _iclerkadddetails;

        public ServiceClerkDetails(IAddClerkDetails clerkadddetail)
        {
            _iclerkadddetails = clerkadddetail;
        }

        public Clerk_details AddClerk(Clerk_details obj)
        {
            try
            {
                return _iclerkadddetails.AddClerk(obj);
            }
            catch (Exception)
            {
                throw;

               
            }
        }

        public Clerk_details UpdateClerk(Clerk_details obj)
        {
            try
            {
                return _iclerkadddetails.UpdateClerk(obj);
            }
            catch (Exception)
            {
                throw;

                
            }
        }


    }
}
