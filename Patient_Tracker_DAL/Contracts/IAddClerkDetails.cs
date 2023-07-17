using Patient_Tracker.Models;
using Patient_Tracker_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Contracts
{
    public interface IAddClerkDetails
    {
     

        public Clerk_details AddClerk(Clerk_details obj);

        public Clerk_details UpdateClerk(Clerk_details obj);
    }
}
