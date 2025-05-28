using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class EmployeeAccess
    {
        [Key]
        public int Employee_Access_ID { get; set; }

        public int Employee_ID { get; set; }
        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
