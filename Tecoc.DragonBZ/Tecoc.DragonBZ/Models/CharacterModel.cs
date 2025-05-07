using System.Text.Json.Serialization;

namespace Tecoc.DragonBZ.Models;

public class CharacterModel
{
    public string? Name { get; set; }

    public string? Ki { get; set; }

    public string? MaxKi { get; set; }

    public string? Race { get; set; }

    public string? Gender { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public string? Affiliation { get; set; }
}
