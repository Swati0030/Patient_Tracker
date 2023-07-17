using System.ComponentModel.DataAnnotations;
namespace patienttracker.Model
{
    public class feedback_details
    {
        [Required]
        public string? prescription_id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime consultation_date { get; set; }

        [StringLength(20)]
        public string doctor_name { get; set; }


        [StringLength(20)]
        public string problem_description { get; set; }

        [StringLength(500)]
        public string additional_notes { get; set; }


        [StringLength(45)]
        public string feedback_detailscol { get; set; }

        [StringLength(20)]
        public string prescription_details_patient_id { get; set; }



    }
}
