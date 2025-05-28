using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [MaxLength(100)]
        public string Department_Name { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
}
}
