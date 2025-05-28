using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Equipment
    {
        [Key]
        public int Equipment_ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string Condition { get; set; }

        public string? Description { get; set; }

        public ICollection<Loan> Loans { get; set; }
}
}
