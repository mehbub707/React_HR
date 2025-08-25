using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class LeaveRecord
    {
        [Key]
        [StringLength(50)]
        public string LeaveRecordID { get; set; } = default!;
        
        public DateTime LeaveDate { get; set; }

        [StringLength(150)]
        public string Remarks { get; set; } = default!;

        [ForeignKey("LeaveType")]
        public string? LeaveTypeID { get; set; } = default!;
        public virtual LeaveType? LeaveType { get; set; }
        
        public string TotalLeave { get; set; } = default!;

        [StringLength(4)]
        public string LeaveEnjoyed { get; set; } = default!;

        [Column(TypeName = "date")]
        public DateTime ApprovedDate { get; set; }

        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformation { get; set; }

        [StringLength(50)]
        public string EntryUser { get; set; } = default!;
       
        public DateTime EntryDate { get; set; }

    }

}
