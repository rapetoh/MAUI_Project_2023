using Microsoft.Maui.ApplicationModel.Communication;
using System.Text.RegularExpressions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using String = System.String;
using System.Data.SqlTypes;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MAUI_Project_2023.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
    public async void OnSignupButtonClicked(object sender, EventArgs e)
    {
        var viewModel = new SignUpViewModel(); // Créez une instance du ViewModel associé à la page SignUpPage
        await Navigation.PushAsync(new SignUpPage(viewModel)); // Naviguez vers la page SignUpPage en passant le ViewModel en tant que paramètre du constructeur
    }
    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        LoadingOverlay.IsVisible = true;

        try
        {
            await Task.Delay(2000);
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", "Une erreur s'est produite lors de la recherche de données.", "OK");
        }
        finally
        {
            LoadingOverlay.IsVisible = false;
        }
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
    void HomePage(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync($"//{nameof(Pages.HomePage)}");
    }
    public string idd = "";
    public async void ConnectionBD(object sender, EventArgs e)
    {
        String mailconn = email.Text;
        String passconn = password.Text;



        using (HttpClient client = new HttpClient())
        {
            try
            {
                //string BaseUrl = DeviceInfo.Platform == DevicePlatform.Android ?
                  //                           "https://10.0.2.2:8000/api/" : "https://localhost:8000/api/";
                // Envoyer la requête POST à l'URL de votre API ou service
                string TodoItemsUrl = "https://f141-196-170-95-47.ngrok-free.app/api/users";
                HttpResponseMessage response = await client.GetAsync(TodoItemsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // La requête a réussi, procédez au traitement de la réponse
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    JObject jsonObject = JObject.Parse(jsonContent);
                    JArray jsonArray = (JArray)jsonObject["hydra:member"];
                    bool flagg = false;

                    foreach (JObject item in jsonArray)
                    {
                        string em = (string)item["email"];
                        string pass = (string)item["password"];
                        idd = (string)item["id"];
                        String name = (string)item["firstname"];

                        if ((em == mailconn) && (pass == passconn))
                        {
                            await DisplayAlert("Connection", "Bienvenue, "+ name, "OK");
                            flagg = true;
                            break;
                        }
                        
                    }
                    if (flagg is false)
                    {
                        await DisplayAlert("Erreur", "Vous n'êtes pas inscris chez ScientMeet. Veuillez créer un compte!", "OK");
                    }
                    else
                    {
                        LoadingOverlay.IsVisible = true;

                        try
                        {
                            await Task.Delay(2000);
                            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                        }
                        catch (Exception ex)
                        {
                            await DisplayAlert("Erreur", "Une erreur s'est produite lors de la recherche de données.", "OK");
                        }
                        finally
                        {
                            LoadingOverlay.IsVisible = false;
                        }
                    }
                }
                else
                {
                    // La requête a échoué, traitez l'erreur en conséquence
                }

                // Vérifier si la requête a réussi

            }
            catch (Exception ex)
            {
                // Gérer les exceptions liées à la requête
                await DisplayAlert("Erreur", "La connection a échouééex", "OK");
            }
        }
    }
}
