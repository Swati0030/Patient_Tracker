using System.ComponentModel.DataAnnotations;
namespace Patient_Tracker.Models
{
    public class user_details
    {
        [StringLength(20)]
        public string user_id;

        [StringLength(20)]
        public string user_name;

        [StringLength(50)]
        public string user_type;

        [StringLength(50)]
        public string user_psw ;
    }
}
