namespace MAUI_Project_2023.Views;

public partial class ListDetail3DetailPage : ContentPage
{
	public ListDetail3DetailPage(ListDetail3DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
