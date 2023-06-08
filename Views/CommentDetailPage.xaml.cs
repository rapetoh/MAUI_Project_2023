namespace MAUI_Project_2023.Views;

public partial class CommentDetailPage : ContentPage
{
	public CommentDetailPage(CommentDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
