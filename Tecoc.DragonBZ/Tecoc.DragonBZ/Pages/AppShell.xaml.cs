namespace Tecoc.DragonBZ.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailCharacterPage), typeof(DetailCharacterPage));

	}
}
