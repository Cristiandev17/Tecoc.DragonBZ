
using Tecoc.DragonBZ.Entities;
using Tecoc.DragonBZ.Models;

namespace Tecoc.DragonBZ.Mappers;

public static class CharacterProfile
{
    public static CharacterEntity ToEntity(this CharacterModel obj)
    {
        return new CharacterEntity
        {
            Id = MongoDB.Bson.ObjectId.GenerateNewId(),
            Name = obj.Name,
            Description = obj.Description,
            Ki = obj.Ki,
            Race = obj.Race,
            Gender = obj.Gender,
            // MaxKi = obj.MaxKi,
            // Image = obj.Image,
            // Affiliation 
        };
    }



}
