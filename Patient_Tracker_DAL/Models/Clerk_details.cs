using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Patient_Tracker_DAL.Models
{
    public class Clerk_details
    {

        [Required]
        public string Clerk_Id { get; set; }

        [StringLength(20)]
        public string Clerk_Name { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
        
        [Range(18, 60)]
        public int age { get; set; }
        
        public string Gender { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

      
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime Date_of_Joining { get; set; }

        [EmailAddress]
        public string Email_Id { get; set; }
    }
}
