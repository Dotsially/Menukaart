namespace Menukaart.View;

public partial class PlaceOfInterestView : ContentPage
{
    public PlaceOfInterestView()
    {
        InitializeComponent();
    }

    public async void ReturnToMap(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}