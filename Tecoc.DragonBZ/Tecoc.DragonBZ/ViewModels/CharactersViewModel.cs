using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<CharacterModel> _chararcters;

    [ObservableProperty]
    private bool _isBusy;

    private ICharacterRepository _characterRepository;

    public CharactersViewModel()
    {
        _characterRepository = Startup.GetService<ICharacterRepository>();
    }

    [RelayCommand]
    public async virtual Task LoadDataCharacters()
    {
        IsBusy = true;
        var characters = await _characterRepository.GetAllCharactersAsync(1);
        Chararcters = new ObservableCollection<CharacterModel>(characters);
        await Task.Delay(TimeSpan.FromSeconds(3));
        IsBusy = false;
    }
}
