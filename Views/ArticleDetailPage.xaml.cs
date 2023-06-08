namespace MAUI_Project_2023.Views;

public partial class ArticleDetailPage : ContentPage
{
	public ArticleDetailPage(ArticleDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
