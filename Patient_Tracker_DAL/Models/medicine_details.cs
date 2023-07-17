using System.Security.Cryptography.Xml;
using System.ComponentModel.DataAnnotations;

namespace Patient_Tracker.Models
{
    public class medicine_details
    {
        [Required]
        public string? medicine_id { get; set; }

         [StringLength(20)]
        public string medicine_name { get; set; }

        [StringLength(300)]
        public string company_name { get; set; }

        [StringLength(50)]
        public string medicine_type { get; set; }

        [StringLength(10)]
        public string storage_type { get; set; }

        [Required(ErrorMessage = "quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "quantity must be a positive value")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "price per unit is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "price per unit must be a positive value")]
        public int price_per_unit { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime manufacture_date { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime expiry_date { get; set; }
        
        [StringLength(20)]
        public string doctor_id { get; set; }

    }
}
