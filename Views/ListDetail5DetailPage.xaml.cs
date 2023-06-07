namespace MAUI_Project_2023.Views;

public partial class ListDetail5DetailPage : ContentPage
{
	public ListDetail5DetailPage(ListDetail5DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
