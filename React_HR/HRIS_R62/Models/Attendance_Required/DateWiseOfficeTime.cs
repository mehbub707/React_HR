using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRIS_R62.Models.Attendance_Required
{
    public class DateWiseOfficeTime
    {
        [Key]
        [StringLength(50)]
        public string DateWiseOfficeTimeID { get; set; } = default!;

        [DataType(DataType.DateTime), Column(TypeName = "datetime")]
        public DateTime ShiftStartDateTime { get; set; }
        [DataType(DataType.DateTime), Column(TypeName = "datetime")]
        public DateTime ShiftEndDateTime { get; set; }
        
        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly ConsideredLunchHour { get; set; }

        [DataType(DataType.Time), Column(TypeName = "time")]
        public TimeOnly BreakDuration { get; set; }


        //added by jahid sir
        //[ForeignKey("EmployeeInformation")]
        //public string EmployeeID { get; set; } = default!;
        //public virtual EmployeeInformation? EmployeeInformation { get; set; }

        public virtual ICollection<ShiftEmployee> ShiftEmployees { get; set; } = new List<ShiftEmployee>();
    }
}
