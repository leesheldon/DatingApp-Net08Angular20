using System.Text.Json.Serialization;

namespace API.Entities;

public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public string? PublicId { get; set; }

    // Navigation property
    [JsonIgnore]
    // so that this does not go back with our Photo object, when we serialize our response into JSON from our API controller.
    public Member Member { get; set; } = null!;
    public string MemberId { get; set; } = null!;
}
