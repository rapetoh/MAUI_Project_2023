namespace MAUI_Project_2023.Views;

public partial class ListDetail2DetailPage : ContentPage
{
	public ListDetail2DetailPage(ListDetail2DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
