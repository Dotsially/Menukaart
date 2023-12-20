using CommunityToolkit.Mvvm.ComponentModel;
using Menukaart.Model;
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
    }
}
