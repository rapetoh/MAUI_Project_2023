namespace MAUI_Project_2023.Views;

public partial class ListDetail3Page : ContentPage
{
	ListDetail3ViewModel ViewModel;

	public ListDetail3Page(ListDetail3ViewModel viewModel)
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
