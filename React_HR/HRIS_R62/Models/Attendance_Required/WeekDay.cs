using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class WeekDay
    {
        [Key]
        [StringLength(50)]
        public string WeekDayID { get; set; }

        [Required]
        public string WeekDayName { get; set; }

        [Required]
        public string WeekDayShortName { get; set; }

        [Required]
        public bool IsWeekend { get; set; }

        public ICollection<ShiftTime>? ShiftTimes { get; set; }
    }
}
