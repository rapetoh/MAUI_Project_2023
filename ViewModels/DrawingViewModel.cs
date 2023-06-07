using CommunityToolkit.Maui.Core;

namespace MAUI_Project_2023.ViewModels;

public partial class DrawingViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}
