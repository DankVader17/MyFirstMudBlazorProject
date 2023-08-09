using System.ComponentModel.DataAnnotations;

namespace MyFirstMudBlazorProject.Data.Models
{
    public class MyTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; } = "";
        public DateTime? DueDate { get; set; } = DateTime.Today;
        public string Priority { get; set; } = "N/A";
        public bool IsComplete { get; set; }
    }
}
