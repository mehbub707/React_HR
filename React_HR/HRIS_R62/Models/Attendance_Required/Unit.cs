using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS_R62.Models.Attendance_Required
{
    public class Unit
    {
        [Key]
        [StringLength(50)]
        public string UnitID { get; set; } = default!;

        [StringLength(10)]
        public string UnitName { get; set; } = default!;

        [ForeignKey("Company")]
        public string? CompanyID { get; set; } = default!;
        public virtual Company? Company { get; set; }

    }
}
