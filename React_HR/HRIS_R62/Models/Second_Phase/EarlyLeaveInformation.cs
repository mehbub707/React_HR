using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Models.Second_Phase
{
    public class EarlyLeaveInformation
    {
        [Key]
        [StringLength(50)]
        public string EarlyLeaveInformationID { get; set; } = default!;
        public DateTime LeaveDate { get; set; }
        public TimeOnly LeaveTime { get; set; }
        [StringLength(150)]
        public string Remarks { get; set; } = default!;

        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
