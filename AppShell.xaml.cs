namespace MAUI_Project_2023;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetail9DetailPage), typeof(ListDetail9DetailPage));
		Routing.RegisterRoute(nameof(ListDetail8DetailPage), typeof(ListDetail8DetailPage));
		Routing.RegisterRoute(nameof(ListDetail7DetailPage), typeof(ListDetail7DetailPage));
		Routing.RegisterRoute(nameof(ListDetail6DetailPage), typeof(ListDetail6DetailPage));
		Routing.RegisterRoute(nameof(ListDetail5DetailPage), typeof(ListDetail5DetailPage));
		Routing.RegisterRoute(nameof(ListDetail4DetailPage), typeof(ListDetail4DetailPage));
		Routing.RegisterRoute(nameof(ListDetail3DetailPage), typeof(ListDetail3DetailPage));
		Routing.RegisterRoute(nameof(ListDetail2DetailPage), typeof(ListDetail2DetailPage));
		Routing.RegisterRoute(nameof(ListDetail1DetailPage), typeof(ListDetail1DetailPage));
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
	}
}
