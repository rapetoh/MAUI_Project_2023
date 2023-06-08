namespace MAUI_Project_2023.Views;

public partial class ConferenceDetailPage : ContentPage
{
	public ConferenceDetailPage(ConferenceDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
