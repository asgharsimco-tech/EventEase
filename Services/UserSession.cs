namespace EventEase.Services;
// Convenience state, not authentication. Never use this to protect sensitive data.
public class UserSession
{
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public bool HasProfile => !string.IsNullOrWhiteSpace(Email);
    public void Clear() { FullName = ""; Email = ""; }
}
