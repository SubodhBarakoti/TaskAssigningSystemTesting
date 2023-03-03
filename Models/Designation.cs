using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskAssigningSystem.Models
{
    public class Designation
    {
        [Key]
        public Guid DesignationId { get; set; }
        

        [Required]
        [DisplayName("Designation Name")]
        [MaxLength(30,ErrorMessage ="Designation Name must be atmost 30 character.")]
        public string? DesignationName { get; set; }


    }
}
