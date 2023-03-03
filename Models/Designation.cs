using System.ComponentModel.DataAnnotations;

namespace TaskAssigningSystem.Models
{
    public class Designation
    {
        [Key]
        public Guid DesignationId { get; set; }
        

        [Required]
        [MaxLength(30,ErrorMessage ="Designation Name must be atmost 30 character.")]
        public string? DesignationName { get; set; }


    }
}
