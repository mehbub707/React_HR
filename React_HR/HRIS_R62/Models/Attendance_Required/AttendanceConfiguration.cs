using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class AttendanceConfiguration
    {
        [Key]
        [StringLength(50)]
        public string AttendanceConfigurationID { get; set; } = default!;
        public TimeSpan GraceTime { get; set; } = default!;  // Changed DataType into TimeSpan By Zahid Sir

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeSpan LunchBreakStartTime { get; set; } = default!;// Changed DataType into TimeSpan By Zahid Sir

        [DataType(DataType.Time), Column(TypeName = "time")] 
        public TimeSpan LunchBreakEndTime { get; set; } = default!; // Changed DataType into TimeSpan By Zahid Sir

        [DataType(DataType.Time), Column(TypeName ="time")]
        public TimeSpan EveningSnacksBreakStartTime { get; set; } = default!; // Changed DataType into TimeSpan By Zahid Sir

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeSpan EveningSnacksBreakEndTime { get; set; } = default!; // Changed DataType into TimeSpan By Zahid Sir
        public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
