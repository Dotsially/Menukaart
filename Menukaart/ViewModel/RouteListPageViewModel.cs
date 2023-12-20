using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.Model;
using Menukaart.View;
using System.Collections.ObjectModel;

namespace Menukaart.ViewModel
{
    public partial class RouteListPageViewModel : ObservableObject
    {
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

        [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task NavigateToMainMenu() => Shell.Current.GoToAsync(nameof(MainPageView));
    }
}
