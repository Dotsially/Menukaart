using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.ViewModel
{
    public partial class SessionInfoPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Sight> _sights;

        [ObservableProperty]
        private Session _session;

        private DatabaseService _databaseService;

        public SessionInfoPageViewModel(Session session, List<Datalink> links, DatabaseService databaseService) 
        {
            Debug.WriteLine(session.date);
            connectSightToLinks(links);
            Session = session;
            _databaseService = databaseService;
        }

        private void connectSightToLinks(List<Datalink> links)
        {
            List<Sight> visitedSights = new List<Sight>();

            visitedSights = links
               .Join(
                   SightData.SightList,
                   datalink => datalink.sight_id,
                   sight => sight.Id,
                   (datalink, sight) => sight
               )
            .ToList();

            Sights = new ObservableCollection<Sight>(visitedSights);
        }

        [RelayCommand]
        Task DeleteSession()
        {
            _databaseService.DeleteSession(Session);
            return Back();
        }


        [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task Back() => Shell.Current.GoToAsync("..");
    }
}
