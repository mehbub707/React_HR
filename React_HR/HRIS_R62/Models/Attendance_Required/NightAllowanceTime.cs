using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class NightAllowanceTime
    {
        [Key]
        [StringLength(50)]
        public string NightAllowanceTimeID { get; set; } 

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [StringLength(10)]
        public string AllowanceType { get; set; } = default!;

        [StringLength(50)]
        public string NightHours { get; set; } = default!;

        [StringLength(50)]
        public string NightMinutes { get; set; } = default!;


        [ForeignKey("EmployeeType")]
        public string EmploymentTypeID { get; set; } = default!;

        public virtual EmploymentType? EmployeeType { get; set; }

    }
}
