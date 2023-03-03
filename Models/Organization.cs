using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskAssigningSystem.Models
{
    /// <summary>
    /// Model for Organization
    /// </summary>
    public class Organization
    {
        [Key]
        public Guid OrganizationId { get; set; }

        [DisplayName("Organization Name")]
        [MaxLength(20,ErrorMessage ="Name of organization should have at most 20 characters.")]
        [Required]
        public string? OrganizationName { get; set; }



        [DisplayName("Organization Email")]
        [DataType(DataType.EmailAddress)]
        public string? OrganizationEmail { get; set; }

        [DisplayName("Password")]
        [Required]
        [MaxLength(16, ErrorMessage = "Password should have at most 16 characters.")]
        [MinLength(5, ErrorMessage = "Password should have at least 5 characters.")]
        [DataType(DataType.Password)]
        public string? OrganizationPassword { get; set; }
    }
}
