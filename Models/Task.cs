using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace TaskAssigningSystem.Models
{
    public class Task
    {
        [Key]
        public Guid TaskId { get; set; }
        [Required]
        [DisplayName("Task Name")]
        [MaxLength(30, ErrorMessage = "Name of skill should have at most 30 characters.")]
        public string? TaskName{ get; set; }

        [Required]
        [DisplayName("Task Description")]
        public string? TaskDescription { get; set; } 

        [Required]
        [DisplayName("Type of Task")]
        public string? TaskType { get; set; }

        [Required]
        [DisplayName("Task Status")]
        public int TaskStatus { get; set; }





    }
}
