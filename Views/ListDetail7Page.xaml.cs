namespace MAUI_Project_2023.Views;

public partial class ListDetail7Page : ContentPage
{
	ListDetail7ViewModel ViewModel;

	public ListDetail7Page(ListDetail7ViewModel viewModel)
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
