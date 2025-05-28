using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Models
{
    public class EmployeeAccess
    {
        [Key]
        public int EmployeeAccessId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
