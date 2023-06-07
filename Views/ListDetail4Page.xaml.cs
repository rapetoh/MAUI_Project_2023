namespace MAUI_Project_2023.Views;

public partial class ListDetail4Page : ContentPage
{
	ListDetail4ViewModel ViewModel;

	public ListDetail4Page(ListDetail4ViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
