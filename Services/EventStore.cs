using System.ComponentModel.DataAnnotations;
using EventEase.Models;
namespace EventEase.Services;
public class EventStore
{
    private readonly List<EventItem> events = new()
    {
        new() { Id = 1, Name = "Technology & Innovation Summit", Location = "Islamabad Convention Centre", Date = DateTime.Today.AddDays(14), Capacity = 40, Description = "Meet technology enthusiasts and explore new ideas in software and innovation." },
        new() { Id = 2, Name = "Creative Design Workshop", Location = "Rawalpindi Learning Hub", Date = DateTime.Today.AddDays(21), Capacity = 25, Description = "A practical session on accessible interfaces and thoughtful user experiences." },
        new() { Id = 3, Name = "Community Networking Evening", Location = "Islamabad Community Hall", Date = DateTime.Today.AddDays(30), Capacity = 60, Description = "Connect with learners and professionals in a friendly community setting." }
    };
    private readonly List<Registration> registrations = new();
    public IReadOnlyList<EventItem> Events => events;
    public IReadOnlyList<Registration> Registrations => registrations;
    public EventItem? Find(int id) => events.FirstOrDefault(e => e.Id == id);
    public int Count(int eventId) => registrations.Count(r => r.EventId == eventId);
    public string? Register(Registration candidate)
    {
        candidate.FullName = candidate.FullName.Trim();
        candidate.Email = candidate.Email.Trim();
        var errors = new List<ValidationResult>();
        if (!Validator.TryValidateObject(candidate, new ValidationContext(candidate), errors, true))
            return errors.First().ErrorMessage ?? "Check your details.";
        var item = Find(candidate.EventId);
        if (item is null) return "This event does not exist.";
        if (Count(item.Id) >= item.Capacity) return "This event is full.";
        if (registrations.Any(r => r.EventId == candidate.EventId && string.Equals(r.Email, candidate.Email, StringComparison.OrdinalIgnoreCase)))
            return "This email is already registered for this event.";
        // Store a copy so subsequent form edits cannot change a saved registration.
        registrations.Add(new Registration { EventId = candidate.EventId, FullName = candidate.FullName, Email = candidate.Email });
        return null;
    }
    public void SetAttendance(Guid id, bool attended)
    {
        var registration = registrations.FirstOrDefault(r => r.Id == id);
        if (registration is not null) registration.Attended = attended;
    }
}
