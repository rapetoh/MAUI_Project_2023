namespace MAUI_Project_2023;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMediaElement()
			.UseMauiCommunityToolkit()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Poppins-Black.ttf", "poppBlack");
                fonts.AddFont("Poppins-Medium.ttf", "poppMed");
                fonts.AddFont("Poppins-Regular.ttf", "poppReg");
                fonts.AddFont("Poppins-SemiBold.ttf", "poppSemiBold");
                fonts.AddFont("MontserratAlternates-Black.ttf", "MonstBlack");
                fonts.AddFont("MontserratAlternates-Bold.ttf", "MonstBold");
                fonts.AddFont("MontserratAlternates-Regular.ttf", "MonstRegular");
                fonts.AddFont("MontserratAlternates-SemiBold.ttf", "MonstSemiBold");
                fonts.AddFont("Montserrat-Black.ttf", "MonBlack");
                fonts.AddFont("Montserrat-Bold.ttf", "MonBold");
                fonts.AddFont("Montserrat-Medium.ttf", "MonMedium");
                fonts.AddFont("Montserrat-Regular.ttf", "MonRegular");
                fonts.AddFont("Montserrat-SemiBold.ttf", "MonBlack");
            });

		builder.Services.AddSingleton<Welcome1ViewModel>();

		builder.Services.AddSingleton<Welcome1Page>();

		builder.Services.AddSingleton<Welcome2ViewModel>();

		builder.Services.AddSingleton<Welcome2Page>();

		builder.Services.AddSingleton<Welcome3ViewModel>();

		builder.Services.AddSingleton<Welcome3Page>();

		builder.Services.AddSingleton<HomeViewModel>();

		builder.Services.AddSingleton<HomePage>();

		builder.Services.AddSingleton<LoginViewModel>();

		builder.Services.AddSingleton<LoginPage>();

		builder.Services.AddSingleton<SignUpViewModel>();

		builder.Services.AddSingleton<SignUpPage>();

		builder.Services.AddSingleton<Blank5ViewModel>();

		builder.Services.AddSingleton<Blank5Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddTransient<ArticleDataService>();
		builder.Services.AddTransient<ArticleDetailViewModel>();
		builder.Services.AddTransient<ArticleDetailPage>();

		builder.Services.AddSingleton<ArticleViewModel>();

		builder.Services.AddSingleton<ArticlePage>();

		builder.Services.AddTransient<CommentDataService>();
		builder.Services.AddTransient<CommentDetailViewModel>();
		builder.Services.AddTransient<CommentDetailPage>();

		builder.Services.AddSingleton<CommentViewModel>();

		builder.Services.AddSingleton<CommentPage>();

		builder.Services.AddTransient<ConferenceDataService>();
		builder.Services.AddTransient<ConferenceDetailViewModel>();
		builder.Services.AddTransient<ConferenceDetailPage>();

		builder.Services.AddSingleton<ConferenceViewModel>();

		builder.Services.AddSingleton<ConferencePage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<NotificationDetailViewModel>();
		builder.Services.AddTransient<NotificationDetailPage>();

		builder.Services.AddSingleton<NotificationViewModel>();

		builder.Services.AddSingleton<NotificationPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail5DetailViewModel>();
		builder.Services.AddTransient<ListDetail5DetailPage>();

		builder.Services.AddSingleton<ListDetail5ViewModel>();

		builder.Services.AddSingleton<ListDetail5Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail6DetailViewModel>();
		builder.Services.AddTransient<ListDetail6DetailPage>();

		builder.Services.AddSingleton<ListDetail6ViewModel>();

		builder.Services.AddSingleton<ListDetail6Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail7DetailViewModel>();
		builder.Services.AddTransient<ListDetail7DetailPage>();

		builder.Services.AddSingleton<ListDetail7ViewModel>();

		builder.Services.AddSingleton<ListDetail7Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail8DetailViewModel>();
		builder.Services.AddTransient<ListDetail8DetailPage>();

		builder.Services.AddSingleton<ListDetail8ViewModel>();

		builder.Services.AddSingleton<ListDetail8Page>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetail9DetailViewModel>();
		builder.Services.AddTransient<ListDetail9DetailPage>();

		builder.Services.AddSingleton<ListDetail9ViewModel>();

		builder.Services.AddSingleton<ListDetail9Page>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<MapPage>();

		builder.Services.AddSingleton<Map1ViewModel>();

		builder.Services.AddSingleton<Map1Page>();

		builder.Services.AddSingleton<WebViewViewModel>();

		builder.Services.AddSingleton<WebViewPage>();

		builder.Services.AddSingleton<WebView1ViewModel>();

		builder.Services.AddSingleton<WebView1Page>();

		builder.Services.AddSingleton<DrawingViewModel>();

		builder.Services.AddSingleton<DrawingPage>();

		builder.Services.AddSingleton<MediaElementViewModel>();

		builder.Services.AddSingleton<MediaElementPage>();

		builder.Services.AddSingleton<SampleViewModel>();

		builder.Services.AddSingleton<SamplePage>();

		return builder.Build();
	}
}
