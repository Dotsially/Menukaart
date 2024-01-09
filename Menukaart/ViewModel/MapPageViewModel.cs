using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement.DataTypes;

namespace Menukaart.ViewModel
{
    public partial class MapPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Sight _currentSight;

        private INavigation _navigation;
        public MapPageViewModel(Sight sight, INavigation navigation)
        {
            _currentSight = sight;
            _navigation = navigation;
        }

        [RelayCommand]
        async Task NavigateToPreviousView() => await _navigation.PopAsync();
    }

}
