namespace MAUI_Project_2023.Views;

public partial class ListDetail2Page : ContentPage
{
	ListDetail2ViewModel ViewModel;

	public ListDetail2Page(ListDetail2ViewModel viewModel)
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
