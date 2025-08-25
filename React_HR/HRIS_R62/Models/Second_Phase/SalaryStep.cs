using HRIS_R62.Models.Attendance_Required;
using HRIS_R62.Models.Second_Phase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.For_Future
{
    public class SalaryStep
    {
        [Key]
        [StringLength(50)]
        public string SalaryStepID { get; set; } = default!;

        [Required]
        [StringLength(50)]
        [ForeignKey("Grade")]
        public string? GradeID { get; set; }
        public virtual Grade? Grade { get; set; }

        [Required]
        public int StepNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasicSalary { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? HouseAllowance { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? MedicalAllowance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ConveyanceAllowance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LunchAllowance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal GrossSalary { get; set; }
        public string StepStatus { get; set; } = "Active";

        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; } = new List<EmployeeInformation>();
        public virtual ICollection<SalaryRecord> SalaryRecords { get; set; } = new List<SalaryRecord>();
    }
}
