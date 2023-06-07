namespace MAUI_Project_2023.Views;

public partial class Map1Page : ContentPage
{
	public Map1Page(Map1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
#if WINDOWS
		// Note that the map control is not supported on Windows.
		// For more details, see https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/map?view=net-maui-7.0
		// For a possible workaround, see https://github.com/CommunityToolkit/Maui/issues/605
		Content = new Label() { Text = "Windows does not have a map control. 😢" };
#endif
	}
}
