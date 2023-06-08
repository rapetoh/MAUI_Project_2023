namespace MAUI_Project_2023.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class NotificationDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}

