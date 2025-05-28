using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }

}
}
