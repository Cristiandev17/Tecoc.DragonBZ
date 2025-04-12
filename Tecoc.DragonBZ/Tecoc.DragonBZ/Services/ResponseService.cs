using Tecoc.DragonBZ.Services.Interfaces;

namespace Tecoc.DragonBZ.Services;

public class ResponseService : IResponseService
{
    public ApiService<T> GetClient<T>()
    {
        return new ApiService<T>("https://dragonball-api.com/api/");
    }
}
