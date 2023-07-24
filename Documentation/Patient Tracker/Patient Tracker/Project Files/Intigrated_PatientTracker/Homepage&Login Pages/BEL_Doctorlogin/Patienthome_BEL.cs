using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Patienthome_BEL
    {
        private string patientid;
        private string prescriptionid;
        private string consultationdate;
        private string doctorname;
        private string problemdesc;
        private string additionalnotes;
        //private string consultationid;

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
        public string Prescriptionid
        {
            set
            {
                prescriptionid = value;
            }
            get
            {
                return prescriptionid;
            }
        }
        public string Consultationdate
        {
            set
            {
                consultationdate=value;
            }
            get
            {
                return consultationdate;
            }
        }
         public string Doctorname
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
         public string Problemdesc
         {
            set
            {
                problemdesc=value;
            }
            get
            {
                return problemdesc;
            }
        }
         public string Additionalnotes
         {
             set
             {
                 additionalnotes = value;
             }
             get
             {
                 return additionalnotes;
             }
         }
         //public string Consultationid
         //{
         //    set
         //    {
         //        consultationid = value;
         //    }
         //    get
         //    {
         //        return consultationid;
         //    }
         //}
    }
}
