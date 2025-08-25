using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class TiffinAllowanceRate
    {
        [Key]
        [StringLength(50)]
        public string TiffinAllowanceRateID { get; set; } = default!;
        public decimal RateInTaka { get; set; }


        [ForeignKey("DesignationID")]
        public string? DesignationID { get; set; } = default!; 
        public virtual Designation? Designation { get; set; }
    }
}
