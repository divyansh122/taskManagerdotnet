using System.ComponentModel.DataAnnotations;

namespace TaskManagerBackend.Models
{
  public class TaskItem
  {
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
  }
}
