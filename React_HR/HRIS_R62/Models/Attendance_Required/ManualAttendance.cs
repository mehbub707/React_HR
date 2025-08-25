using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
        public class ManualAttendance
        {
            [Key]
            [StringLength(50)]
            public string ManualAttendanceID { get; set; } = default!;
            [Column(TypeName = "date")]
            public DateTime AttendanceDate { get; set; }

            [StringLength(12)]
            public string AttendanceTime { get; set; } = default!;
            [Column(TypeName = "date")]
            public DateTime EntryDate { get; set; }

            [StringLength(150)]
            public string Reason { get; set; } = default!;

            [Required, StringLength(50)]
            public string EntryUser { get; set; } = default!;

            [Required, StringLength(12)]
            public string OutTime { get; set; } = default!;

            [StringLength(150)]
            public string Remarks { get; set; } = default!;

            [ForeignKey("EmployeeInformation")]
            public string EmployeeID { get; set; } = default!;
            public virtual EmployeeInformation? EmployeeInformation { get; set; }
        }
    }
