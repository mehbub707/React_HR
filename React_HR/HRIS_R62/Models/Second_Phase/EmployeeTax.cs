using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Models.For_Future
{
    public class EmployeeTax
    {
        [Key]
        [StringLength(50)]
        public string EmployeeTaxID { get; set; }

        
        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Salary Date")]

        public DateTime SalaryDate { get; set; }

        [StringLength(50), Display(Name = "Tax Month")]

        public string TaxMonth { get; set; }

        [StringLength(5)]
        public string TaxYear { get; set; }

        public double? MonthlyGross { get; set; }

        public double? CalculatedTax { get; set; }

        public double? ProposedTax { get; set; }

        [StringLength(50)]
        public string LocalAreaClerance { get; set; }

        [StringLength(50)]
        public string LocalAreaRemarks { get; set; }

        [ForeignKey("EmployeeInformation")]
        public string EmployeeID { get; set; }
        public virtual EmployeeInformation? EmployeeInformation { get; set; }
    }

}

