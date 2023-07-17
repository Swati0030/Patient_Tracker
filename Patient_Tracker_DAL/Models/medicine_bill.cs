using System.ComponentModel.DataAnnotations;
namespace Patient_Tracker.Models
{
    public class medicine_bill
    {
        [Required]
        public int Cc_Number { get; set; }

        [StringLength(20)]
        public string patient_id { get; set; }

        [StringLength(20)]
        public string doctor_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime consul_date { get; set; }

        [StringLength(20)]
        public string prescription_id { get; set; }

        [StringLength(20)]
        public string doctor_Id { get; set; }
        public DateTime date_of_prescription { get; set; }

        [StringLength(20)]
        public string medicine_id { get; set; }

        [StringLength(20)]
        public string Patient_No { get; set; }
    }
}
