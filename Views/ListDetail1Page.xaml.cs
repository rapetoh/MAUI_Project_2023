namespace MAUI_Project_2023.Views;

public partial class ListDetail1Page : ContentPage
{
	ListDetail1ViewModel ViewModel;

	public ListDetail1Page(ListDetail1ViewModel viewModel)
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
