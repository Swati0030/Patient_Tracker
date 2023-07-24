using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL_Docregistration
{
    public class Docregistration_BEL
    {
        //private string userid;
        private string password;
        //private string username;
        private string usertype;
        private string doctorid;
        private string doctorname;
        private string qualification;
        private int age;
        private string address;
        private int experience;
        private double contactnumber;
        private string emailid;
      




        //public string _userid
        //{
        //    set
        //    {
        //      userid=value;
        //    }
        //    get
        //    {
        //        return (userid);
        //    }
        //}
        public string _password
        {
            set
            {
                 password=value;
            }
            get
            {
                return (password);
            }
        }
        //public string _username
        //{
        //    set
        //    {
        //         username=value ;
        //    }
        //    get
        //    {
        //        return (username);
        //    }
        //}
        public string _usertype
        {
            set
            {
                 usertype=value;
            }
            get
            {
                return (usertype);
            }
        }

        public string _doctorid
        {
            set
            {
                doctorid = value;
            }
            get
            {
                return doctorid;
            }
        }
        public string _doctorname
        {
            set
            {
                 doctorname=value;
            }
            get
            {
                return doctorname;
            }

        }
        public string _qualification
        {
            set
            {
                 qualification=value;
            }
            get
            {
                return qualification;
            }
        }
        public int _age
        {
            set
            {
                 age=value;
            }
            get
            {
                return age;
            }
        }
        public string _address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public int _experience
        {
            set
            {
                 experience=value;
            }
            get
            {
                return experience;
            }
        }
        public double _contactnumber
        {
            set
            {
              contactnumber=  value ;
            }
            get
            {
                return contactnumber;
            }
        }
        public string _emailid
        {
            set
            {
                emailid = value;
            }
            get
            {
                return emailid;
            }
        }

       
    }
}
