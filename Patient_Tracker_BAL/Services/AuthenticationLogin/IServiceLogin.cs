using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Tracker_BAL.Services.AuthenticationLogin
{
    public interface IServiceLogin
    {
        
        
            public string Authenticate(string user_id, string user_psw);
        
    }
}
