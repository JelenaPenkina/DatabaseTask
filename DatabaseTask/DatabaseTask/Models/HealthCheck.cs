using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Models
{
    public class HealthCheck
    {
        [Key]

        public int HealthCheckId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
