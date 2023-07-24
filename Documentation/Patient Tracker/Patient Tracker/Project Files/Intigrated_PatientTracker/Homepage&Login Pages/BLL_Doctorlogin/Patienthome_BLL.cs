using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BEL;
using DAL;

namespace BLL
{
    public class Patienthome_BLL
    {
        Patienthome_DAL phdal = new Patienthome_DAL();
        public int feedback_bll(Patienthome_BEL phbel)
        {
             return phdal.feedback_dal(phbel);
        }
        public int submitfeedback_bll(Patienthome_BEL phbel)
        {
            return phdal.submitfeedback_dal(phbel);
        }
        public SqlDataAdapter viewhistory_bll(Patienthome_BEL phbel)
        {
            return phdal.viewhistory_dal(phbel);
        }
        public SqlDataAdapter prescriptionscreen_bll(string s)
        {
            return phdal.prescriptionscreen_dal(s);
        }
        public List<string> ddlist_bll(Patienthome_BEL phbel)
        {
            return phdal.ddlist_dal(phbel);
        }
    }
}
