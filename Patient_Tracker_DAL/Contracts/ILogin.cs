using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_DAL.Contracts
{
    public interface ILogin
    {
        public string GetUserRole(string userId);
        public bool VerifyUser(string userId, string password);

        public string GenerateJwtToken(string userId, string role);


    }
}
