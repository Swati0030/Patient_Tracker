using System.ComponentModel.DataAnnotations;

namespace Patient_Tracker.Models
{
    public class prescription_details
    {
        [StringLength(20)]
        public string prescription_id { get; set; }
        
        [Required(ErrorMessage = "prescription date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime prescription_date { get; set; }

        [StringLength(20)]
        public string doctor_id { get; set; }

        [StringLength(20)]
        public string patient_No { get; set; }

        [StringLength(20)]
        public string medicine_id { get; set; }

        [StringLength(700)]
        public string problem_description { get; set; }

        [StringLength(300)]
        public string prescribed_medicine_name { get; set; }

        [StringLength(20)]
        public string alternative_medicine_name { get; set; }

        [Required(ErrorMessage = "Quantity to purchase is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity to purchase must be a positive value")]
        public int quantity_to_purchase { get; set; }

        [Required(ErrorMessage = "Dosage is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Dosage must be a positive value")]
        public int dosage { get; set; }

        [StringLength(20)]
        public string duration { get; set; }

        [StringLength(100)]
        public string add_note { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime next_consaltation_date { get; set; }

        [Required(ErrorMessage = "Consultation ID is required.")]
        [RegularExpression("^C\\d{3}$", ErrorMessage = "consaltation_id should the format CXXX(e.g. M123)")]
        public string consaltation_id { get; set; }

        [Required(ErrorMessage = "Patient ID is required.")]
      
        public string patient_id { get; set; }

       

        [Required(ErrorMessage = "medicine_bill_cc_number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "medicine_bill_cc_number must be a positive value")]
        public int medicine_bill_cc_number { get; set; }
    }
}
