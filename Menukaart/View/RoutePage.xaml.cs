namespace Menukaart.View;

public partial class RoutePage : ContentPage
{
    public RoutePage()
    {
        InitializeComponent();
    }

    private async void ReturnToMap(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}