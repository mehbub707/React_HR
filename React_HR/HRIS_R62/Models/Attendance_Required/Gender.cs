using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.Attendance_Required
{
    public class Gender
    {
        public string GenderID { get; set; }
        public string GenderName { get; set; } = default!;
        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;
        public virtual EmployeeInformation? EmployeeInformations { get; set; }        
    }
}
