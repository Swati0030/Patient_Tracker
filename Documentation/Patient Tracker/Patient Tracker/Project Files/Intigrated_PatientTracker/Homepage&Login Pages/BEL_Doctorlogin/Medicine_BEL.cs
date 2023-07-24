using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class Medicine_BEL
    {
        private long medicineid;
        private string doctorid;
        private string medicinename;
        private string companyname;
        private string medicinetype;
        private string storagetype;
        private int quantity;
        private int priceperunit;
        private DateTime manufacturingdate;
        private DateTime expirydate;

        public long Medicineid
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
        public string Medicinename
        {
            set
            {
                medicinename = value;
            }
            get
            {
                return medicinename;
            }
        }
        public string Companyname
        {
            set
            {
                companyname = value;
            }
            get
            {
                return companyname;
            }
        }
        public string Medicinetype
        {
            set
            {
                medicinetype = value;
            }
            get
            {
                return medicinetype;
            }
        }
        public string Storagetype
        {
            set
            {
                storagetype = value;
            }
            get
            {
                return storagetype;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public int Priceperunit
        {
            set
            {
                priceperunit = value;
            }
            get
            {
                return priceperunit;
            }
        }
        public DateTime Manufacturingdate
        {
            set
            {
                manufacturingdate = value;
            }
            get
            {
                return manufacturingdate;
            }
        }
        public DateTime Expirydate
        {
            set
            {
                expirydate = value;
            }
            get
            {
                return expirydate;
            }
        }
    }
}
