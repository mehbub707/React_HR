using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Models.For_Future
{
    public class HoliDayBillRate
    {
        [Key]
        [StringLength(50)]
        public string HoliDayBillRateID { get; set; } 
        public int SerialNumber { get; set; }
        public decimal SalaryMinimum { get; set; }
        public decimal SalaryMaximum { get; set; }
        public int HoliDayBillRateValue { get; set; }

        
        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }
}
