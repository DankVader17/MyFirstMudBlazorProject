using System.ComponentModel.DataAnnotations;

namespace MyFirstMudBlazorProject.Data.Models
{
    public class MyTask
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
        public bool IsComplete { get; set; }
    }
}
