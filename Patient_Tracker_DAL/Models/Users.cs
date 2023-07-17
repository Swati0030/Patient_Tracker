using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Patient_Tracker_DAL.Models
{
    public class Users
    {
        [StringLength(20)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
