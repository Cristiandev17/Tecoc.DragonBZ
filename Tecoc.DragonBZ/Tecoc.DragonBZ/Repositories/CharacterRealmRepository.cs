using Tecoc.DragonBZ.Entities;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.Repositories;

public class CharacterRealmRepository : ICharacterRealmRepository
{
    private readonly IContextDataBase _contextRealm;

    public CharacterRealmRepository()
    {
        _contextRealm = Startup.ServicesProvider.GetService<IContextDataBase>();
    }

    public void SaveCharater(CharacterEntity item)
    {
        var realm = _contextRealm.GetRealm();
        realm.Write(() =>
       {
           realm.Add(item);
       });
    }

    public IQueryable<CharacterEntity> GetAllObjects()
    {
        var realm = _contextRealm.GetRealm();
        return realm.All<CharacterEntity>();
    }
}
