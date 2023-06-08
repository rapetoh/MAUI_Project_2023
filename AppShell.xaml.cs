
namespace MAUI_Project_2023;

public partial class AppShell : Shell
{


	public async void testconn()
	{
        string isLoggedIn = await SecureStorage.GetAsync("IsLoggedIn");
        string username = await SecureStorage.GetAsync("Username");
        string mail = await SecureStorage.GetAsync("Email");
        string author = await SecureStorage.GetAsync("isAuthor");
        string proof = await SecureStorage.GetAsync("isProofreader");
        string presi = await SecureStorage.GetAsync("isCopresident");
        string participant = await SecureStorage.GetAsync("isParticipant");

		usrnm.Text = username;

		maill.Text = mail;

        if (isLoggedIn == "true")
        {
            // L'utilisateur est déjà connecté, naviguer directement vers la page suivante (par exemple, MainPage2)
			welcm1.IsVisible = false;
        }
		
    }
    public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetail9DetailPage), typeof(ListDetail9DetailPage));
		Routing.RegisterRoute(nameof(ListDetail8DetailPage), typeof(ListDetail8DetailPage));
		Routing.RegisterRoute(nameof(ListDetail7DetailPage), typeof(ListDetail7DetailPage));
		Routing.RegisterRoute(nameof(ListDetail6DetailPage), typeof(ListDetail6DetailPage));
		Routing.RegisterRoute(nameof(ListDetail5DetailPage), typeof(ListDetail5DetailPage));
		Routing.RegisterRoute(nameof(NotificationDetailPage), typeof(NotificationDetailPage));
		Routing.RegisterRoute(nameof(ConferenceDetailPage), typeof(ConferenceDetailPage));
		Routing.RegisterRoute(nameof(CommentDetailPage), typeof(CommentDetailPage));
		Routing.RegisterRoute(nameof(ArticleDetailPage), typeof(ArticleDetailPage));
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));

		testconn();

	}

}
