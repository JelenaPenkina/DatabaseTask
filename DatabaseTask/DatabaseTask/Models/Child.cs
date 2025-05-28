using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Child
    {
        [Key]
        public int Child_ID { get; set; }

        public int Employee_ID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public Employee Employee { get; set; }
    }
}
