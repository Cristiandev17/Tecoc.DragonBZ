using Tecoc.DragonBZ.Models;
using Tecoc.DragonBZ.Repositories.Interfaces;
using Tecoc.DragonBZ.Responses;
using Tecoc.DragonBZ.Services.Interfaces;

namespace Tecoc.DragonBZ.Repositories;

public class CharacterRepository : ICharacterRepository
{
    private readonly IResponseService _apiResponseService;

    public CharacterRepository()
    {
        _apiResponseService = Startup.GetService<IResponseService>();
    }

    public async Task<List<CharacterModel>> GetAllCharactersAsync(int page)
    {
        var characterClient = _apiResponseService.GetClient<ApiResponse>();

        var response = await characterClient.GetAsync<ApiResponse>(resource: $"characters?page={page}&limit=10");

        if (response != null)
        {
            return response.Items ?? new List<CharacterModel>();
        }
        else
        {
            throw new Exception("Error fetching characters");
        }
    }
}
