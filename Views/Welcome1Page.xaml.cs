namespace MAUI_Project_2023.Views;

public partial class Welcome1Page : ContentPage
{
	public Welcome1Page(Welcome1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
    private void Suivant1(object sender, EventArgs e)
    {
        // Créer une nouvelle instance de la page vers laquelle vous souhaitez rediriger
        var nextPage = new Welcome2Page();

        // Accéder à la NavigationPage actuelle (si vous utilisez une navigation basée sur la pile)
        var navigation = Application.Current.MainPage.Navigation;

        // Utiliser la méthode de navigation appropriée pour rediriger vers la nouvelle page
        // Par exemple, utiliser PushAsync pour ajouter la page à la pile de navigation
        navigation.PushAsync(nextPage);
    }
}
