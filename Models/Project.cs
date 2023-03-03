using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace TaskAssigningSystem.Models
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }
        [Required]
        [DisplayName("Project Name")]
        [MaxLength(30, ErrorMessage = "Name of Project should have at most 30 characters.")]
        public string? ProjectName { get; set; }
        [Required]
        [DisplayName("Project  Description")]
        public string? ProjectDescription { get; set; }

        [Required]
        
      
        [DisplayName ("Project Deadline")]
        public  DateTime ProjectDeadline { get; set; }

        [Required]

        [DisplayName("Project Status")]
        public int ProjectStatus { get; set; }
       
      
    }
}

    

