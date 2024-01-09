using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class SightView : ContentPage
{
    public SightView(MapPageViewModel mapPageViewModel)
    {
        InitializeComponent();
        BindingContext = mapPageViewModel;
    }
}