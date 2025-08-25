using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Models.For_Future
{
    public class EmployeeComplaint
    {
        [Key]
        [StringLength(50)]
        public string ComplaintID { get; set; }


        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Complaint Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ComplaintDate { get; set; }

        [MaxLength(100)]
        [Display(Name = "Complaint Type")]
        public string ComplaintType { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [MaxLength(50)]
        [Display(Name = "Status")]
        public string Status { get; set; }

        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
