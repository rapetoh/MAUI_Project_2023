namespace MAUI_Project_2023.Views;

public partial class ListDetailPage : ContentPage
{
	ListDetailViewModel ViewModel;

	public ListDetailPage(ListDetailViewModel viewModel)
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
