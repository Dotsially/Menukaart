using PolylineEncoder.Net.Utility;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace Menukaart.View;

public partial class MapPage : ContentPage
{
    private readonly IGeolocation _geolocation;
    MapSpan mapSpan;



    public MapPage(IGeolocation geolocation)
    {
        _geolocation = geolocation;
        InitializeComponent();

        Location location = new Location(51.5840246, 4.7953861, 17);
        mapSpan = new MapSpan(location, 0.01, 0.01);
        map.MoveToRegion(mapSpan);
        map.IsShowingUser = true;
        map.Pins.Add(new Pin() { Location = location, Label = "My Home", Address = "My Address" });

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


}