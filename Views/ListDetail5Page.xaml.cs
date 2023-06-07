namespace MAUI_Project_2023.Views;

public partial class ListDetail5Page : ContentPage
{
	ListDetail5ViewModel ViewModel;

	public ListDetail5Page(ListDetail5ViewModel viewModel)
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
