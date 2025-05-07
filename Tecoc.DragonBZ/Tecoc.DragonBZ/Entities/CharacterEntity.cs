using MongoDB.Bson;
using Realms;

namespace Tecoc.DragonBZ.Entities;

public class CharacterEntity : RealmObject
{
    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId? Id { get; set; }

    [MapTo("name")]
    public string? Name { get; set; }

    [MapTo("ki")]
    public string? Ki { get; set; }

    // [MapTo("maxKi")]
    // public string? MaxKi { get; set; }

    [MapTo("race")]
    public string? Race { get; set; }

    [MapTo("gender")]
    public string? Gender { get; set; }

    [MapTo("description")]
    public string? Description { get; set; }

    // [MapTo("image")]
    // public string? Image { get; set; }

    // [MapTo("affiliation")]
    // public string? Affiliation { get; set; }

    // [MapTo("status")]
    // public int Status { get; set; }
}
