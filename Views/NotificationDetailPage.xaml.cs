namespace MAUI_Project_2023.Views;

public partial class NotificationDetailPage : ContentPage
{
	public NotificationDetailPage(NotificationDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
