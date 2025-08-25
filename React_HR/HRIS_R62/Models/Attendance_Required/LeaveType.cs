using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.Attendance_Required
{
    public class LeaveType
    {
        [Key]
        [StringLength(50)]
        public string LeaveTypeID { get; set; }
        [StringLength(100)]
        public string LeaveTypeName { get; set; }

        [StringLength(50)]
        public string EntryUser { get; set; } = default!;

        public DateTime EntryDate { get; set; }

        public virtual ICollection<LeaveRecord> LeaveRecords { get; set; } = new List<LeaveRecord>();
        public virtual ICollection<LeaveApproval> LeaveApprovals { get; set; } = new List<LeaveApproval>();
    }

}
