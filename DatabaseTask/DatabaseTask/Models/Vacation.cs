using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Models
{
    public class Vacation
    {
        [Key]
        public int VacationId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ExtraChildDayVacation { get; set; }

        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
