using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BEL;



namespace BLL
{
    public class Doctorlogin_BLL 
    {
        public int Doctorlogin(Doctorlogin_BEL beldlogin)
    {
        Doctorlogin_DAL daldlogin = new Doctorlogin_DAL();
        try
        {
            return daldlogin.Doctorlogin(beldlogin);
        }
        catch (Exception)
        {
            
            throw;
        }
        finally
        {
            daldlogin = null;
        }
    }
    }
}
