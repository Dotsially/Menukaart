using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class RouteListPageView : ContentPage
{
    public RouteListPageView()
    {
        InitializeComponent();
        BindingContext = new RouteListPageViewModel();
    }
}