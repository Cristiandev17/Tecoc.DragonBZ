using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Tecoc.DragonBZ.Repositories;
using Tecoc.DragonBZ.Repositories.Interfaces;
using Tecoc.DragonBZ.Services;
using Tecoc.DragonBZ.Services.Interfaces;
using Tecoc.DragonBZ.ViewModels;

namespace Tecoc.DragonBZ;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<ICharacterRepository, CharacterRepository>();
		builder.Services.AddSingleton<IResponseService, ResponseService>();

		builder.Services.AddTransient<CharactersViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		var app = builder.Build();

		Startup.ServicesProvider = app.Services;

		return builder.Build();
	}
}
