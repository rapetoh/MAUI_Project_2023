namespace MAUI_Project_2023.Views;

public partial class Welcome3Page : ContentPage
{
	public Welcome3Page()
	{
		InitializeComponent();
		//BindingContext = viewModel;
	}
	//private void Sinscrire(object sender, EventArgs e)
    //{
        // Créer une nouvelle instance de la page vers laquelle vous souhaitez rediriger
      //  var nextPage = new SignupPage();

        // Accéder à la NavigationPage actuelle (si vous utilisez une navigation basée sur la pile)
        //var navigation = Application.Current.MainPage.Navigation;

        // Utiliser la méthode de navigation appropriée pour rediriger vers la nouvelle page
        // Par exemple, utiliser PushAsync pour ajouter la page à la pile de navigation
        //navigation.PushAsync(nextPage);

    //}
    public async void Sinscrire(object sender, EventArgs e)
    {
        var viewModel = new SignUpViewModel(); // Créez une instance du ViewModel associé à la page SignUpPage
        await Navigation.PushAsync(new SignUpPage(viewModel)); // Naviguez vers la page SignUpPage en passant le ViewModel en tant que paramètre du constructeur
    }

}
