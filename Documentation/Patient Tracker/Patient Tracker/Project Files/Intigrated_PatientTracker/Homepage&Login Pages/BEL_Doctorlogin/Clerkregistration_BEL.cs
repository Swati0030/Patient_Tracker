using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Clerkregistration_BEL
    {
        //private string userid;
        private string clerkid;
        private string clerkname;
        private int age;
        private string address;
        private double contactnumber;
        private string password;
        private DateTime doj;
        private string emailid;
        private string usertype;
        //private string username;
       

            //public string _userid{
            //    set{userid=value;}
            //    get{return userid;}            
            //}
            //public string _username
            //{
            //    set
            //    {
            //        username = value;
            //    }
            //    get
            //    {
            //        return (username);
            //    }
            //}

        public string _clerkid
        {
            set
            {
                 clerkid=value;
            }
           get 
            {
                return (clerkid);
            }
        }
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
        
        public string _clerkname
        {
            set
            {
                clerkname = value;
            }
            get
            {
                return (clerkname);
            }
        }
        public int _age
        {
            set
            {
                age = value;
            }
            get
            {
                return (age);
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
                return (address);
            }
        }
        public double _contactnumber
        {
            set
            {
                contactnumber = value;
            }
            get
            {
                return (contactnumber);
            }
        }
        public string _password
        {
            set
            {
                password = value;
            }
            get
            {
                return (password);
            }
        }
        public DateTime _doj
        {
            set
            {
                doj = value;
            }
            get
            {
                return (doj);
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
                return (emailid);
            }
        }
       
        }
    }

