using System.ComponentModel.DataAnnotations;
namespace Patient_Tracker.Models
  
{
    public class doctor_details
    {
        [Required]
        public string doctor_Id { get; set; }

        public string doctor_Name { get; set; }

        [Range(18, 99)]
        public int age { get; set; }

        [Range(1, 60)]
        public int Experience { get; set; }

        [StringLength(100)]
        public string Qualification { get; set; }

        [StringLength(1000)]
       public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]
        public long Contact_No { get; set; }

        [EmailAddress]
        public string Email_Id { get; set; }

    }
}
