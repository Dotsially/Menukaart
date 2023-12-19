using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Menukaart.Model;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace Menukaart.View;

public partial class MapPage : ContentPage
{
    private readonly IGeolocation _geolocation;
    MapSpan mapSpan;
    PointOfInterestList poiList;

    public MapPage(IGeolocation geolocation)
    {
        _geolocation = geolocation;
        poiList = new();
        poiList.InitializeList();
        InitializeComponent();

        var poi = PointOfInterestList.poiList.First();
        mapSpan = new MapSpan(poi.Location, 0.01, 0.01);
        map.MoveToRegion(mapSpan);
        map.IsShowingUser = true;
        map.Pins.Add(new Pin() { Location = poi.Location, Label = poi.Name, Address = "" });

        StartListening();
    }

    //Start listening to user location
    private async Task<bool> StartListening()
    {
        GeolocationAccuracy accuracy = GeolocationAccuracy.Best;
        var request = new GeolocationListeningRequest(accuracy);

        _geolocation.LocationChanged += GeolocationLocationChanged;
        var success = await Geolocation.StartListeningForegroundAsync(request);
        return success;
    }

    void GeolocationLocationChanged(object sender, GeolocationLocationChangedEventArgs e)
    {
        var newLocation = $"{e.Location.Latitude} {e.Location.Longitude}";
        var toast = Toast.Make(newLocation, ToastDuration.Short);
        toast.Show();
        Location location = new Location(e.Location.Latitude, e.Location.Longitude);
        mapSpan = new MapSpan(location, 0.01, 0.01);
        map.MoveToRegion(mapSpan);

    }

    private async void GoToPointOfInterest(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceOfInterestView());
    }

    private async void GoToRoutes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RoutePage());
    }


}