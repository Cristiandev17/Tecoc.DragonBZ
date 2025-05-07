using CommunityToolkit.Mvvm.ComponentModel;
using Tecoc.DragonBZ.Models;

namespace Tecoc.DragonBZ.ViewModels;

[QueryProperty(nameof(Character), nameof(Character))]
public partial class DetailCharacterViewModel : ObservableObject
{

    [ObservableProperty]
    private CharacterModel character;

    public DetailCharacterViewModel()
    {
        var name = Character?.Name;
    }

}
