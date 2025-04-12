using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.DragonBZ.Models;

namespace Tecoc.DragonBZ.ViewModels;

public partial class CharactersLocalViewModel : ObservableObject
{

    [ObservableProperty]
    public ObservableCollection<CharacterModel> _chararcters;

    [RelayCommand]
    public async virtual Task LoadDataCharacters()
    {


    }

}
