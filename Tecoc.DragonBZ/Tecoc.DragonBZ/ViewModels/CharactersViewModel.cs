using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.DragonBZ.Mappers;
using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Pages;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<CharacterModel> _characters;

    [ObservableProperty]
    private bool _isBusy;

    private ICharacterRepository _characterRepository;
    private ICharacterRealmRepository _characterRealmRepository;

    public CharactersViewModel()
    {
        _characterRepository = Startup.GetService<ICharacterRepository>();
        _characterRealmRepository = Startup.GetService<ICharacterRealmRepository>();
    }

    [RelayCommand]
    public async virtual Task LoadDataCharacters()
    {
        IsBusy = true;
        var characters = await _characterRepository.GetAllCharactersAsync(1);
        Characters = new ObservableCollection<CharacterModel>(characters);
        await Task.Delay(TimeSpan.FromSeconds(3));
        IsBusy = false;
    }

    [RelayCommand]
    public async Task GoToDetail(CharacterModel character)
    {
        // var parameters = new Dictionary<string, object> { { "Character", character } };
        // await Shell.Current.GoToAsync(nameof(DetailCharacterPage), true, parameters);


        var item = character.ToEntity();
        _characterRealmRepository.SaveCharater(item);

    }
}
