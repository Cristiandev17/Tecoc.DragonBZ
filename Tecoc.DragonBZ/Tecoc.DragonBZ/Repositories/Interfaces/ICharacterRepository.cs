using Tecoc.DragonBZ.Models;

namespace Tecoc.DragonBZ.Repositories.Interfaces;

public interface ICharacterRepository
{
    Task<List<CharacterModel>> GetAllCharactersAsync(int page);
}
