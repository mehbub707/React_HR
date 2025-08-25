using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.Attendance_Required
{
    public class Religion
    {
        public string ReligionID { get; set; }
        public string ReligionName { get; set; }
        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; } = default!;

        public virtual EmployeeInformation? EmployeeInformations { get; set; }

    }
}
