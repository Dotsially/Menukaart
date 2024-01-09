using Menukaart.DataManagement;
using Menukaart.ViewModel;
using System.Diagnostics;

namespace Menukaart.View;

public partial class RouteListPageView : ContentPage
{
    public RouteListPageView(DatabaseService databaseService)
    {
        InitializeComponent();
        BindingContext = new RouteListPageViewModel(databaseService);
    }
}