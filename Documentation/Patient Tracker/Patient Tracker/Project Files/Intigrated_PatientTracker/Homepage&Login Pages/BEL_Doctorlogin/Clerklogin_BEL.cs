using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Clerklogin_BEL
    {
        private string userid;
        private string password;
        private string usertype;

        public string UserId
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
        public string _Pass
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
