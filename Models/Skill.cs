using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskAssigningSystem.Models
{
    public class Skill
    {
        [Key]
        public Guid SkillId { get; set; }

        [Required]
        [DisplayName("Skill Name")]
        [MaxLength(30,ErrorMessage = "Skill name should have at most 30 characters.")]
        public string? SkillName { get; set; }
    }
}
