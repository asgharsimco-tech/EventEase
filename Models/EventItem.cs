using System.ComponentModel.DataAnnotations;
namespace EventEase.Models;
public class EventItem
{
    public int Id { get; set; }
    [Required, StringLength(80, MinimumLength = 3)]
    public string Name { get; set; } = "";
    [Required, StringLength(120, MinimumLength = 3)]
    public string Location { get; set; } = "";
    public DateTime Date { get; set; } = DateTime.Today.AddDays(7);
    public string Description { get; set; } = "";
    public int Capacity { get; set; } = 30;
}
