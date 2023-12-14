using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class TutorialPageView : ContentPage
{
	public TutorialPageView()
	{
		InitializeComponent();
		BindingContext = new TutorialPageViewModel();
	}
}