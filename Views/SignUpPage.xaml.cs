using System.Text.RegularExpressions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using String = System.String;
using System.Text;

namespace MAUI_Project_2023.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage(SignUpViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	public async void OnConnectButtonClicked(object sender, EventArgs e)
    {
        var viewModel = new LoginViewModel(); // Créez une instance du ViewModel associé à la page SignUpPage
        await Navigation.PushAsync(new LoginPage(viewModel)); // Naviguez vers la page SignUpPage en passant le ViewModel en tant que paramètre du constructeur
    }
    void OnEntryPasswordChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = password.Text;
    }
    void OnEntryPasswordCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    void OnEntryEmailChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = email.Text;
    }
    void OnEntryEmailCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    void OnEntryUsernameChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = email.Text;
    }
    void OnEntryUsernameCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        string selectedOption = (string)picker.SelectedItem;
        // Utilisez la valeur sélectionnée comme vous le souhaitez
        // par exemple, affectez-la à une variable ou appelez une méthode avec cette valeur
    }


    public bool IsEmailValid(string email)
    {
        // Expression régulière pour la validation de l'adresse e-mail
        string pattern = @"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$";

        // Vérifier si l'adresse e-mail correspond au format attendu
        bool isValid = Regex.IsMatch(email, pattern);

        return isValid;
    }
    public bool IsPasswordMatch(String passw ,String passwcf)
    {
        if (passw == passwcf)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// ...

public async void inscriptionDB(object sender, EventArgs e)
{
    string apiUrl = "https://6849-196-170-95-47.ngrok-free.app/api/users";
    string mail = email.Text;
    string usrnm = username.Text;
    string pass = password.Text;
    string passconf = passwordconf.Text;
    string state = (string)etat.SelectedItem;

    // Convertir l'état en booléens
    bool auteur = false;
    bool relecteurs = false;
    bool participant = false;
    bool coPresi = false;

    switch (state)
    {
        case "Relecteurs(Partcipant)":
            relecteurs = true;
            break;
        case "Co-Président(Partcipant)":
            coPresi = true;
            break;
        case "Simple particiant(Partcipant)":
            participant = true;
            break;
        case "Auteur d'articles(Partcipant)":
            auteur = true;
            break;
        default:
            break;
    }

        LoadingOverlay.IsVisible = true;

        var inscrData = new { firstname = usrnm, lastname= "unknown", email = mail, password = pass, origin = "unknown", isParticipant = participant, isProofreader = relecteurs, isCopresident = coPresi, isAuthor = auteur };


        if (IsEmailValid(mail) && IsPasswordMatch(pass, passconf))
    {
        await DisplayAlert("Mail", "Format correcte", "OK");

        string jsonData = JsonConvert.SerializeObject(inscrData);

        using (HttpClient client = new HttpClient())
        {
            try
            {
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                LoadingOverlay.IsVisible = true;
                    if (response.IsSuccessStatusCode)
                {

                    await DisplayAlert("Success", "Vous êtes enrégistré avec succès!\nConnectez-vous maintenant pour commencer l'aventure", "OK");
                    var viewModel = new LoginViewModel(); // Créez une instance du ViewModel associé à la page SignUpPage
                    await Navigation.PushAsync(new LoginPage(viewModel)); // Naviguez vers la page SignUpPage en passant le ViewModel en tant que paramètre du constructeur
                    }
                    else
                {
                    await DisplayAlert("Erreur", "Une erreur s'est produite, ressayez plus tard.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", "Une erreur s'est produite, ressayez plus tard.", "OK");
                LoadingOverlay.IsVisible = false;

            }

            }
    }
    else
        {
            await DisplayAlert("Mail ou Mot de passe", "Format de mail incorrect ou mots de passe entrés différents", "OK");
        }
    }

}
