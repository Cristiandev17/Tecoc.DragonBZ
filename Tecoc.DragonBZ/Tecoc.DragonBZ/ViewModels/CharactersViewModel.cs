using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    private ICharacterRepository _characterRepository;

    public CharactersViewModel()
    {
        _characterRepository = Startup.GetService<ICharacterRepository>();
    }
}
