namespace MAUI_Project_2023.Views;

public partial class ListDetail9Page : ContentPage
{
	ListDetail9ViewModel ViewModel;

	public ListDetail9Page(ListDetail9ViewModel viewModel)
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
