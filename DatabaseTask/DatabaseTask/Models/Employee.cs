using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DatabaseTask.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        [StringLength(25)]
        public string Email { get; set; }

        public int DepartmentId { get; set; }
        public int JobTitleId { get; set; }

        [MaxLength(20)]
        public string SocialSecurityNumber { get; set; }

        [MaxLength(25)]
        public string PhoneNumber { get; set; }

        public string? Description { get; set; }

        public Department? Department { get; set; }
        public JobTitle? JobTitle { get; set; }

        public ICollection<Child> Children { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<HealthCheck> HealthChecks { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<SickLeave> SickLeaves { get; set; }
        public ICollection<EmployeeAccess> EmployeeAccesses { get; set; }
}
}
