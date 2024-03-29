﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.DataManagement.DataTypes;
using Menukaart.Model;
using Menukaart.View;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Menukaart.DataManagement;

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

        private DatabaseService _databaseService;

        public RouteListPageViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            SightData sights = new();
           
            Routes.Add(new()
            {
                Name = "Holland Delight",
                Description = "Some nice typical Dutch restaurants",
                ImageSource = SightData.SightList[0].Image.Source,
                SightList = new List<Sight>{ SightData.SightList[0], SightData.SightList[1], SightData.SightList[3] }
            });
            Debug.WriteLine(Routes.First().SightList.First().Name);

            Debug.WriteLine("BS" + Routes.First().ImageSource);
            Routes.Add(new()
            {
                Name = "Kids menu",
                Description = "Great for little explorers",
                ImageSource = SightData.SightList[2].Image.Source,
                SightList = new List<Sight> { SightData.SightList[2], SightData.SightList[5], SightData.SightList[5] }
            });

            Routes.Add(new()
            {
                Name = "Vegan route",
                Description = "Enjoy a lack of meat",
                ImageSource = SightData.SightList[7].Image.Source,
                SightList = new List<Sight> { SightData.SightList[7], SightData.SightList[6], SightData.SightList[8] }
            });

            Routes.Add(new()
            {
                Name = "Route 4",
                Description = "Let's cook!",
                ImageSource = SightData.SightList[9].Image.Source,
                SightList = new List<Sight> { SightData.SightList[9], SightData.SightList[10], SightData.SightList[11] }
            });
        }

        private async void OnItemSelected(RouteListPageModel selectedRoute)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "route", selectedRoute },
                { "DatabaseService", _databaseService}
            };
            await Shell.Current.GoToAsync($"MapPageView", navigationParameter);
        }

        [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task NavigateToMainMenu() => Shell.Current.GoToAsync(nameof(MainPageView));
    }
}
