using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.View;

namespace Menukaart.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
	public MainPageViewModel()
	{

	}

    [RelayCommand]
    Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));
}