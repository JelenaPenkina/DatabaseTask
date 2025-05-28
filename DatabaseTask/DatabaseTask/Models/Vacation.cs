using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Vacation
    {
        [Key]
        public int Vacation_ID { get; set; }

        public int Employee_ID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Extra_Child_Day_Vacation { get; set; }

        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
