using Menukaart.DataManagement.DataTypes;
using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class SessionInfoPageView : ContentPage
{
	
	public SessionInfoPageView()
	{
		InitializeComponent();
		BindingContext = new SessionInfoPageViewModel();
	}

 
}