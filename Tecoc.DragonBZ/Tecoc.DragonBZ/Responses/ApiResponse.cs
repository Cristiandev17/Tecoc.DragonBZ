using System.Text.Json.Serialization;
using Tecoc.DragonBZ.Models;

namespace Tecoc.DragonBZ.Responses;

public class ApiResponse
{
    [JsonPropertyName("items")]
    public List<CharacterModel>? Items { get; set; }
}
