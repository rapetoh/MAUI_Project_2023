namespace MAUI_Project_2023.Views;

public partial class ListDetail1DetailPage : ContentPage
{
	public ListDetail1DetailPage(ListDetail1DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
