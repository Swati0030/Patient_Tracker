using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEL;
using DAL;

namespace BLL
{
     public class Clerklogin_BLL
        {
            public int Clerklogin(Clerklogin_BEL belclogin)
            {
                Clerklogin_DAL dalclogin = new Clerklogin_DAL();            
                try
                {
                    return dalclogin.Clerklogin(belclogin);
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {

                    dalclogin = null;
                }

            }

        }
    }

