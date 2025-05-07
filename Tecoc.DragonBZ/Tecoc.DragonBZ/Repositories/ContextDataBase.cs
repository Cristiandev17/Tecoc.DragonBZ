

using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.Repositories;

public class ContextDataBase : IContextDataBase
{
    public Realms.Realm GetRealm()
    {
        return Realms.Realm.GetInstance();
    }
}
