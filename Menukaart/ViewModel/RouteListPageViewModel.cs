using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.DataManagement.DataTypes;
using Menukaart.Model;
using Menukaart.View;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Menukaart.ViewModel
{
    public partial class RouteListPageViewModel : ObservableObject
    {


        private Command<RouteListPageModel> _itemSelectedCommand;
        public Command<RouteListPageModel> ItemSelectedCommand =>
            _itemSelectedCommand ?? (_itemSelectedCommand = new Command<RouteListPageModel>(OnItemSelected));

        [ObservableProperty]
        private ObservableCollection<RouteListPageModel> _routes = new ObservableCollection<RouteListPageModel>();

        private RouteListPageModel _selectedRoute;
        public RouteListPageModel SelectedRoute {
            get => _selectedRoute;
            set => SetProperty(ref _selectedRoute, value); }

        public RouteListPageViewModel()
        {
            SightData sights = new();
           
            Routes.Add(new()
            {
                Name = "Route 1",
                Description = "Let's cook!",
                ImageName = SightData.SightList[0].Image.Source.ToString(),
                SightList = new List<Sight>{ SightData.SightList[0], SightData.SightList[1], SightData.SightList[3] }
            });
            Debug.WriteLine(Routes.First().SightList.First().Name);

            Debug.WriteLine("BS" + Routes.First().ImageName);
            Routes.Add(new()
            {
                Name = "Route 2",
                Description = "Let's cook!",
                ImageName = SightData.SightList[2].Image.Source.ToString(),
                SightList = new List<Sight> { SightData.SightList[2], SightData.SightList[4], SightData.SightList[5] }
            });

            Routes.Add(new()
            {
                Name = "Route 3",
                Description = "Let's cook!",
                ImageName = SightData.SightList[7].Image.ToString(),
                SightList = new List<Sight> { SightData.SightList[7], SightData.SightList[6], SightData.SightList[8] }
            });

            Routes.Add(new()
            {
                Name = "Route 4",
                Description = "Let's cook!",
                ImageName = SightData.SightList[9].Image.ToString(),
                SightList = new List<Sight> { SightData.SightList[9], SightData.SightList[10], SightData.SightList[11] }
            });
        }

        private async void OnItemSelected(RouteListPageModel selectedRoute)
        {
            if(selectedRoute == null)
            {
                Debug.WriteLine("ROUTE IS NULL");
            }
            else
            {
                Debug.WriteLine($"{selectedRoute.Name} is selected");
            }
                await Shell.Current.GoToAsync($"MapPageView?route={selectedRoute}");
        }

        [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task NavigateToMainMenu() => Shell.Current.GoToAsync(nameof(MainPageView));
    }
}
