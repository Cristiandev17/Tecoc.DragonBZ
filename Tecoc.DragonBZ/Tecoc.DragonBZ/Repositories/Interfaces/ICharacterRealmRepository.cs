using Tecoc.DragonBZ.Entities;

namespace Tecoc.DragonBZ.Repositories.Interfaces;

public interface ICharacterRealmRepository
{
    void SaveCharater(CharacterEntity item);

    IQueryable<CharacterEntity> GetAllObjects();
}
