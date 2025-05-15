using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.DragonBZ.Mappers;
using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Repositories.Interfaces;

namespace Tecoc.DragonBZ.ViewModels;

[QueryProperty(nameof(Character), nameof(Character))]
public partial class DetailCharacterViewModel : ObservableObject, IQueryAttributable
{

    private ICharacterRealmRepository _characterRealmRepository;

    [ObservableProperty]
    private CharacterModel character;

    public DetailCharacterViewModel()
    {
        _characterRealmRepository = Startup.GetService<ICharacterRealmRepository>();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Character = (CharacterModel)query["character"];
    }

    [RelayCommand]
    public async Task Save()
    {
        var item = Character.ToEntity();
        //_characterRealmRepository.SaveCharater(item);
    }

}
