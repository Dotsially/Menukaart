using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.Model;
using Menukaart.View;
using System.Collections.ObjectModel;

namespace Menukaart.ViewModel
{
    public partial class RouteListPageViewModel : ObservableObject
    {


        private Command<RouteListPageModel> _itemSelectedCommand;
        public Command<RouteListPageModel> ItemSelectedCommand =>
            _itemSelectedCommand ?? (_itemSelectedCommand = new Command<RouteListPageModel>(OnItemSelected));

        [ObservableProperty]
        private ObservableCollection<RouteListPageModel> _routes = new ObservableCollection<RouteListPageModel>();

        public RouteListPageViewModel()
        {
            Routes.Add(new()
            {
                Name = "Route 1",
                Description = "Let's cook!",
                ImageName = "temp.jpg"
            });

            Routes.Add(new()
            {
                Name = "Route 1",
                Description = "Let's cook!",
                ImageName = "temp.jpg"
            });

            Routes.Add(new()
            {
                Name = "Route 1",
                Description = "Let's cook!",
                ImageName = "temp.jpg"
            });

            Routes.Add(new()
            {
                Name = "Route 1",
                Description = "Let's cook!",
                ImageName = "temp.jpg"
            });
        }

        private async void OnItemSelected(RouteListPageModel selectedRoute)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedSession", selectedRoute },
                { "SavedSights", Routes.IndexOf(selectedRoute)},
            };
            await Shell.Current.GoToAsync(nameof(RouteListPageModel), navigationParameter);
        }

            [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task NavigateToMainMenu() => Shell.Current.GoToAsync(nameof(MainPageView));
    }
}
