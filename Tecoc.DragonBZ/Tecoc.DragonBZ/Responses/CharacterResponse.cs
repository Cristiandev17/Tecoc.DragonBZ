
using System.Text.Json.Serialization;


namespace Tecoc.DragonBZ.Responses;

public class CharacterResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ki")]
    public string? Ki { get; set; }

    [JsonPropertyName("maxKi")]
    public string? MaxKi { get; set; }

    [JsonPropertyName("race")]
    public string? Race { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("affiliation")]
    public string? Affiliation { get; set; }
}
