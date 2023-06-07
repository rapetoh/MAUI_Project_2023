namespace MAUI_Project_2023.Views;

public partial class ListDetail4DetailPage : ContentPage
{
	public ListDetail4DetailPage(ListDetail4DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
