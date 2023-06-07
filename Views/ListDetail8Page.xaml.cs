namespace MAUI_Project_2023.Views;

public partial class ListDetail8Page : ContentPage
{
	ListDetail8ViewModel ViewModel;

	public ListDetail8Page(ListDetail8ViewModel viewModel)
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
