using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class ShiftTime
    {
        [Key]
        [StringLength(50)]
        public string ShiftID { get; set; }

        [StringLength(30)]
        public string ShiftName { get; set; } = default!;

        [Column(TypeName = "time"), DisplayFormat(DataFormatString = "{0:hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public TimeOnly ShiftStart { get; set; }

        [Column(TypeName = "time"), DisplayFormat(DataFormatString = "{0:hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public TimeOnly ShiftEnd { get; set; }

        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly StartDate { get; set; }

        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly EndDate { get; set; }

        public int? ConsideredLunchHour { get; set; }

        public decimal BreakDuration { get; set; }

        [ForeignKey(nameof(Models.Attendance_Required.WeekDay))]
        public string WeekDayID { get; set; } = default!;

        public virtual WeekDay? WeekDay { get; set; }

        public virtual ICollection<EmployeeInformation>? EmployeeInformation { get; set; }
    }
}
