using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }

        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public Employee Employee { get; set; }
    }
}
