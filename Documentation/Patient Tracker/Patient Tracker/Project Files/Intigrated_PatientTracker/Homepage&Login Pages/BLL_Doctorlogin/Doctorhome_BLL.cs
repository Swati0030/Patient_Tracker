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
   public class Doctorhome_BLL
    {
       Doctorhome_DAL dhdal = new Doctorhome_DAL();
       public SqlDataAdapter consultationhistory_bll(Doctorhome_BEL dhbel)
       {
           return dhdal.consulattionhistory_dal(dhbel);
       }
       public string consultationid_bll()
       {
           return dhdal.consulattionid_dal();
       }
       public int prescriptionnumber_bll(Doctorhome_BEL dhbel)
       {
           return dhdal.prescriptionnumber_dal(dhbel);
       }
       public int createprescription_bll(Doctorhome_BEL dhbel)
       {
           return dhdal.createprescription_dal(dhbel);
       }
       public int check_bll(Doctorhome_BEL dhbel)
       {
           return dhdal.check_dal(dhbel);
       }
       public string getname_bll(Doctorhome_BEL dhbel)
       {
           return dhdal.getname_dal(dhbel);
       }
    }
}
