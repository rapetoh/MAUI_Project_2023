using System.Text.RegularExpressions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using String = System.String;

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
    public async void inscriptionDB(object sender, EventArgs e)
    {
        String mail = email.Text;
        String usrnm = username.Text;
        String pass = password.Text;
        String passconf = passwordconf.Text;
        String state = (String)((Picker)sender).SelectedItem;
        bool auteur;
        bool relecteurs;
        bool participant;
        bool coPresi;

        switch (state)
        {
            case "Relecteurs(Partcipant)":
                relecteurs = true;
                auteur = false;
                participant = false;
                coPresi = false;
                break;
            case "Co-Président(Partcipant)":
                relecteurs = false;
                auteur = false;
                participant = false;
                coPresi = true;
                break;
            case "Simple particiant(Partcipant)":
                relecteurs = false;
                auteur = false;
                participant = true;
                coPresi = false;
                break;
            case "Auteur d'articles(Partcipant)":
                relecteurs = false;
                auteur = true;
                participant = false;
                coPresi = false;
                break;
            default:
                relecteurs = false;
                auteur = false;
                participant = false;
                coPresi = false;
                break;
        }

        string auteurStr = auteur.ToString(); // "True";
        string relecteurStr = relecteurs.ToString(); // "True";
        string participantStr = participant.ToString(); // "True";
        string coPresiStr = coPresi.ToString(); // "True";


        var inscrData = new { mail, usrnm, pass, passconf, auteurStr, relecteurStr,participantStr,coPresiStr };

        if (IsEmailValid(mail) && (IsPasswordMatch(pass, passconf)))
        {
            await DisplayAlert("Mail", "Format correcte", "OK");


            String JsoninscrData = JsonConvert.SerializeObject(inscrData);


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Envoyer la requête POST à l'URL de votre API ou service
                    HttpResponseMessage response = await client.PostAsync("https://f141-196-170-95-47.ngrok-free.app/api/users", new StringContent(JsoninscrData));

                    // Vérifier si la requête a réussi
                    if (response.IsSuccessStatusCode)
                    {
                        // La requête a réussi, effectuer des actions supplémentaires si nécessaire
                        await DisplayAlert("Success", "Vous êtes enrégistré avec succès!\nConnectez-vous maintenant pour commencer l'aventure", "OK");
                    }
                    else
                    {
                        // La requête a échoué, traiter les erreurs éventuelles
                        await DisplayAlert("Erreur", "Une erreur s'est produite, ressayez plus tard.", "OK");
                    }
                }
                catch (Exception ex)
                {
                    // Gérer les exceptions liées à la requête
                    await DisplayAlert("Erreur", "Une erreur s'est produite, ressayez plus tard.", "OK");
                }
            }
        }
        else
        {
            await DisplayAlert("Mail ou Mot de passe", "Format de mail incorrect ou mot de passes entés différents", "OK");
        }

    }
}
