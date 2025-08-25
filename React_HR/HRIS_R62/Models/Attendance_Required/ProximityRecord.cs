using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HRIS_R62.Models.Attendance_Required
{
    public class ProximityRecord
    {
        [Key]
        [StringLength(50)]
        public string ProximityRecordID { get; set; }

        public string ProximityNumber { get; set; } = default!;

        [DataType(DataType.Date), Column(TypeName = "Date")] 
        public DateOnly RecordDate { get; set; }



        //Ommited Below By Zahid Sir
        //[DataType(DataType.Time), Column(TypeName = "time")]

        //public TimeOnly RecordTime { get; set; }
        
        //Regular Time
        [DataType(DataType.Time), Column(TypeName = "time")] //Timeonly added by zahID sir
        public TimeOnly InTime { get; set; } = default!;

        [DataType(DataType.Time), Column(TypeName = "time")] //Timeonly added by zahID sir 
        public TimeOnly OutTime { get; set; } = default!;


        //Ommited Below By Zahid Sir
        //public string AttendanceType { get; set; } = "Regular";

        //[StringLength(20)]
        public string Status { get; set; } = "Valid";

        [StringLength(50)]
        public string VerifiedBy { get; set; } = default!;
        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformation { get; set; }

    }

}
