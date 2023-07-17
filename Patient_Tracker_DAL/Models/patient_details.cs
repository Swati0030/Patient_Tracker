using System.ComponentModel.DataAnnotations;
namespace Patient_Tracker.Models
{
    public class patient_details
    {
        [Required]
        public string Patient_No { get; set; }

        [StringLength(20)]
        public string Patient_Name { get; set; }

        [Range(18, 99)]
        public int age { get; set; }
        
        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]
        public long Contact_No { get; set; }

        [EmailAddress]
        public string Email_Id { get; set; }
    }
}
