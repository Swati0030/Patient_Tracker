using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL_PatientRegistration
{
    
    public class PatientRegistration_BEL
    {
        private string patientname;
        private int patientage;
        private string patientaddress;
        private double patientcontactnumber;
        private string emailid;
        private string gender;
        //private string username;
        private string patientid;
        private string password;
        private string usertype;
        public string Patientname
        {

            set
            {
                patientname = value;
            }
            get
            {
                return patientname;
            }
        }
        public int Patientage
        {

            set
            {
                patientage = value;
            }
            get
            {
                return patientage;
            }
        }
        public string Patientaddress
        {

            set
            {
                patientaddress = value;
            }
            get
            {
                return patientaddress;
            }
        }
        public double Patientcontactnumber
        {

            set
            {
                patientcontactnumber = value;
            }
            get
            {
                return patientcontactnumber;
            }
        }
        public string Emailid
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
        public string Gender
        {

            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        //public string Username
        //{

        //    set
        //    {
        //        username = value;
        //    }
        //    get
        //    {
        //        return username;
        //    }
        //}
        public string Patientid
        {

            set
            {
                patientid = value;
            }
            get
            {
                return patientid;
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
        public string Usertype
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
