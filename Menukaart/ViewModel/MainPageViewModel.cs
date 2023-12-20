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

    [RelayCommand]
    Task NavigateToSessionList() => Shell.Current.GoToAsync(nameof(DatabasePageView));

    [RelayCommand]
    Task NaviageToRouteList() => Shell.Current.GoToAsync(nameof(RouteListPageView));

    [RelayCommand]
    Task NavigateToMap() => Shell.Current.GoToAsync(nameof(MapPageView));
}