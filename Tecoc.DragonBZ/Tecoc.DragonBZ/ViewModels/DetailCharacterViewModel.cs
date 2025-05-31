using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui;
using Tecoc.DragonBZ.Mappers;
using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Repositories.Interfaces;
using static System.Net.Mime.MediaTypeNames;

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
        Location location = await Geolocation.Default.GetLastKnownLocationAsync();

        if (location != null)
        {
            var toast = Toast.Make($"Latitude: {location.Latitude}, Longitude: {location.Longitude}", CommunityToolkit.Maui.Core.ToastDuration.Long, 14);
        }
        else 
        {
            var toast = Toast.Make($"Location not found", CommunityToolkit.Maui.Core.ToastDuration.Long, 14);
        }
          


        //var item = Character.ToEntity();
        //_characterRealmRepository.SaveCharater(item);
    }

}
