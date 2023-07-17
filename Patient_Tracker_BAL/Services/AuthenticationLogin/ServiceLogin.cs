using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.AuthenticationLogin
{
    public class ServiceLogin:IServiceLogin
    {
        private readonly ILogin _iLogin;
        public ServiceLogin(ILogin Login)
        {
            _iLogin = Login;
        }



        public string Authenticate(string user_id, string user_psw)
        {
            try
            {


                // Verify the user from the users table
                bool isUserValid = _iLogin.VerifyUser(user_id, user_psw);



                if (!isUserValid)
                {
                    // Return null or throw an exception indicating authentication failure
                    return "User Does not exists";
                }
                string role = _iLogin.GetUserRole(user_id);
                string token = _iLogin.GenerateJwtToken(user_id, role);



                return token;
            }
            catch (Exception)
            {
                throw;
            }




        }

    }
}
    

