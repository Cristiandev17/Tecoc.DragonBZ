using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.ViewModels;

public partial class CharactersLocalViewModel : ObservableObject
{

    [ObservableProperty]
    public ObservableCollection<CharacterModel> _chararcters;

    private ICharacterRealmRepository _characterRealmRepository;

    public CharactersLocalViewModel()
    {
        _characterRealmRepository = Startup.GetService<ICharacterRealmRepository>();
    }

    [RelayCommand]
    public async virtual Task LoadDataCharacters()
    {
        var list = _characterRealmRepository.GetAllObjects();

    }

}
