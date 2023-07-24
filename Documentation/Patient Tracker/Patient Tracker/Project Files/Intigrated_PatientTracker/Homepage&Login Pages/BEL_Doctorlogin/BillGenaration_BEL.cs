using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class BillGeneration_BEL
    {
        private string patientid;
        private string doctorname;
        private string consultationdate;
        private string prescriptionnumber;
        private string doctorid;
        private string dateofprescription;
        private string medicineid;
        private string patientnumber;
        private string quantocon;
        private int consulfee;
        private int medicinefee;
        private int totalcost;
        private string paymentmode;
        private int ccnumber;
        
        private string isbillpaid;
        private string nextconsuldate;


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
        public string Doctorname
        {
            set
            {
                doctorname = value;
            }
            get
            {
                return doctorname;
            }
        }
        public string Consultationdate
        {
            set
            {
                consultationdate = value;
            }
            get
            {
                return consultationdate;
            }
        }
        public string Prescriptionnumber
        {
            set
            {
                prescriptionnumber = value;
            }
            get
            {
                return prescriptionnumber;
            }
        }
        public string Doctorid
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
        public string Dateofprescription
        {
            set
            {
                dateofprescription = value;
            }
            get
            {
                return dateofprescription;
            }
        }
        public string Medicineid
        {
            set
            {
                medicineid = value;
            }
            get
            {
                return medicineid;
            }
        }
        public string Patientnumber
        {
            set
            {
                patientnumber = value;
            }
            get
            {
                return patientnumber;
            }
        }
        public string Quantocon
        {
            set
            {
                quantocon = value;
            }
            get
            {
                return quantocon;
            }
        }
        public int Consulfee
        {
            set
            {
                consulfee = value;
            }
            get
            {
                return consulfee;
            }
        }
        public int Medicinefee
        {
            set
            {
                medicinefee= value;
            }
            get
            {
                return medicinefee;
            }
        }
        public int Totalcost
        {
            set
            {
                totalcost = value;
            }
            get
            {
                return totalcost;
            }
        }
        public string Paymentmode
        {
            set
            {
                paymentmode = value;
            }
            get
            {
                return paymentmode;
            }
        }
        public int Ccnumber
        {
            set
            {
                this.ccnumber = value;
            }
            get
            {
                return this.ccnumber;
            }
        }


        public string Isbillpaid
        {
            set
            {
                isbillpaid= value;
            }
            get
            {
                return isbillpaid;
            }
        }
        public string Nextconsuldate
        {
            set
            {
                nextconsuldate = value;
            }
            get
            {
                return nextconsuldate; ;
            }
        }

    }
}
