namespace MAUI_Project_2023.Views;

public partial class WebViewPage : ContentPage
{
	public WebViewPage(WebViewViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
