using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
   public class Patientlogin_BEL
    {
        private string userid;
        private string password;
        private string usertype;

        public string Userid
        {

            set
            {
                userid = value;
            }
            get
            {
                return userid;
            }
        }
        public string Password
        {

            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public string UserType
        {

            set
            {
                usertype = value;
            }
            get
            {
                return usertype;
            }
        }
    }
}
