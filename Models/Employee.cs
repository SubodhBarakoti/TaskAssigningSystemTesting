using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskAssigningSystem.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        [MaxLength(30, ErrorMessage = "Name of employee should have at most 30 characters.")]
        public string? EmployeeName { get; set; }

        [Required]
        [DisplayName("Employee Email")]
        public string? EmployeeEmail { get; set; }

        [Required]
        [DisplayName("Employee Password")]
        [MaxLength(16, ErrorMessage = "Password should have at most 16 characters.")]
        [MinLength(5, ErrorMessage = "Password should have at least 5 characters.")]
        [DataType(DataType.Password)]
        public string? EmployeePassword { get; set; }

        [Required]
        public string? EmployeeDesignation { get; set; }
    }
}
