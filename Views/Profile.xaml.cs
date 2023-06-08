namespace MAUI_Project_2023.Views;

public partial class Profile : ContentPage
{

    public async void profiledisplay()
    {
        string isLoggedIn = await SecureStorage.GetAsync("IsLoggedIn");
        string username = await SecureStorage.GetAsync("Username");
        string mail = await SecureStorage.GetAsync("Email");
        string author = await SecureStorage.GetAsync("isAuthor");
        string proof = await SecureStorage.GetAsync("isProofreader");
        string presi = await SecureStorage.GetAsync("isCopresident");
        string participant = await SecureStorage.GetAsync("isParticipant");

        if (author == "True")
        {
            statut.Text = "Auteur";
        }
        else if (proof == "True")
        {
            statut.Text = "Relecteur";
        }
        else if (presi == "True")
        {
            statut.Text = "Président";
        }
        else if (participant == "True")
        {
            statut.Text = "Participant";
        }
        usrnm.Text = username;

    }

    public Profile()
	{
		InitializeComponent();
        profiledisplay();

	}

	public async void Logout(object sender, EventArgs e)
	{
        await SecureStorage.SetAsync("IsLoggedIn","false");
        var viewModel = new LoginViewModel(); // Créez une instance du ViewModel associé à la page SignUpPage
        await Navigation.PushAsync(new LoginPage(viewModel)); // Naviguez vers la page SignUpPage en passant le ViewModel en tant que paramètre du constructeur
    }
}