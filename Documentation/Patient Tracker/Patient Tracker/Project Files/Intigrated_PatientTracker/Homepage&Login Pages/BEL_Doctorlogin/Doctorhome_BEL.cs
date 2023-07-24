using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Doctorhome_BEL
    {
        private string patientid;
        private string prescriptionid;
        private DateTime prescriptiondate;
        private string doctorid;
        private long patientnumber;
        private string problemdescription;
        private string prescribedmedicinename;
        private string alternatemedicinename;
        private string quantitytopurchase;
        private int dosage;
        private int durationtocontinuemedicine;
        private string additionalnotes;
        private DateTime nextconsultationdate;
        private string consultationid;       
        private int prescriptionnumber;
        private DateTime consultationdate;

        public int Prescriptionnumber
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
        public DateTime Prescriptiondate
        {

            set
            {
                prescriptiondate = value;
            }
            get
            {
                return prescriptiondate;
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
        public long Patientnumber
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
        public string Problemdescription
        {

            set
            {
                problemdescription = value;
            }
            get
            {
                return problemdescription;
            }
        }
        public string Prescribedmedicinename
        {

            set
            {
                prescribedmedicinename = value;
            }
            get
            {
                return prescribedmedicinename;
            }
        }
        public string Alternatemedicinename
        {

            set
            {
                alternatemedicinename = value;
            }
            get
            {
                return alternatemedicinename;
            }
        }
        public string Quantitytopurchase
        {

            set
            {
                quantitytopurchase = value;
            }
            get
            {
                return quantitytopurchase;
            }
        }
        public int Dosage
        {

            set
            {
                dosage = value;
            }
            get
            {
                return dosage;
            }
        }
        public int Durationtocontinuemedicine
        {

            set
            {
                durationtocontinuemedicine = value;
            }
            get
            {
                return durationtocontinuemedicine;
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
        public DateTime Nextconsultationdate
        {

            set
            {
                nextconsultationdate = value;
            }
            get
            {
                return nextconsultationdate;
            }
        }
        public string Consultationid
        {

            set
            {
                consultationid = value;
            }
            get
            {
                return consultationid;
            }
        }
        public DateTime Consultationdate
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
    }
}
