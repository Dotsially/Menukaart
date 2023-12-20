using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
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

        public SessionInfoPageViewModel(Session session, List<Datalink> links) 
        {
            Debug.WriteLine(session.date);
            connectSightToLinks(links);
            Session = session;
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
        Task Back() => Shell.Current.GoToAsync("..");
    }
}
