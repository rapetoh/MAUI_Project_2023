﻿namespace MAUI_Project_2023.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetail8DetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
