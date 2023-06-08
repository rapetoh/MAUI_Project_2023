using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Text;

namespace MAUI_Project_2023.Views;

public partial class AddConference : ContentPage
{
	public AddConference()
	{
		InitializeComponent();
	}
    private async void OnAddClicked(object sender, EventArgs e)
    {
        string nam = nameEntry.Text;
        string sigle = sigleEntry.Text;
        string them = themeEntry.Text;
        DateTime submissionstartDate = submissionStartDatePicker.Date;
        DateTime submissionEndDate = submissionEndDatePicker.Date;
        DateTime resultsDate = resultsDatePicker.Date;
        DateTime inscriptionstartDate = inscriptionStartDatePicker.Date;
        DateTime inscriptionEndDate = inscriptionEndDatePicker.Date;
        DateTime conferenceStartDate = conferenceStartDatePicker.Date;
        DateTime conferenceEndDate = conferenceEndDatePicker.Date;

        // Créer une nouvelle instance de Conference avec les valeurs saisies
        var conference = new
        {
            name = nam,
            acronym = sigle,
            theme = them,
            submissionStartDate = submissionstartDate,
            submissionDeadlines = submissionEndDate,
            resultDate = resultsDate,
            inscriptionStartDate = inscriptionstartDate,
            inscriptionDeadline = inscriptionEndDate,
            startDate = conferenceStartDate,
            endDate = conferenceEndDate
        };

        string apiUrl = "https://6849-196-170-95-47.ngrok-free.app/api/conferences";

        string jsonData = JsonConvert.SerializeObject(conference);

        using (HttpClient client = new HttpClient())
        {
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(apiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Succès", "La conférence a été ajoutée.", "OK");
            }
            else
            {
                await DisplayAlert("Erreur", "Une erreur s'est produite, ressayez plus tard.", "OK");
            }
        }


        nameEntry.Text = string.Empty;
        sigleEntry.Text = string.Empty;
        themeEntry.Text = string.Empty;
        submissionStartDatePicker.Date = DateTime.Now;
        submissionEndDatePicker.Date = DateTime.Now;
        resultsDatePicker.Date = DateTime.Now;
        inscriptionStartDatePicker.Date = DateTime.Now;
        inscriptionEndDatePicker.Date = DateTime.Now;
        conferenceStartDatePicker.Date = DateTime.Now;
        conferenceEndDatePicker.Date = DateTime.Now;

        // Afficher une notification ou effectuer d'autres actions après l'ajout de la conférence
       
    }
}