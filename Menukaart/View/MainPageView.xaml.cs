using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class MainPageView : ContentPage
{
	public MainPageView()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}