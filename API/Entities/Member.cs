using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Member
{
    public string Id { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
    public string? ImageUrl { get; set; }
    public required string DisplayName { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public string? Description { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }

    // Navigation property
    [JsonIgnore]
    // so that this does not go back with our Member object, when we serialize our response into JSON from our API controller.
    public List<Photo> Photos { get; set; } = [];

    [JsonIgnore]
    // so that this does not go back with our Member object, when we serialize our response into JSON from our API controller.
    [ForeignKey(nameof(Id))]
    public AppUser User { get; set; } = null!;
}
