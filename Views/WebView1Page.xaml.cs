namespace MAUI_Project_2023.Views;

public partial class WebView1Page : ContentPage
{
	public WebView1Page(WebView1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
