using System.ComponentModel.DataAnnotations;
namespace EventEase.Models;
public class Registration
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int EventId { get; set; }
    [Required(ErrorMessage = "Enter your full name."), StringLength(80, MinimumLength = 2)]
    public string FullName { get; set; } = "";
    [Required(ErrorMessage = "Enter your email address."), EmailAddress, StringLength(120)]
    public string Email { get; set; } = "";
    public bool Attended { get; set; }
}
