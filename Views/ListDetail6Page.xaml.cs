namespace MAUI_Project_2023.Views;

public partial class ListDetail6Page : ContentPage
{
	ListDetail6ViewModel ViewModel;

	public ListDetail6Page(ListDetail6ViewModel viewModel)
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
