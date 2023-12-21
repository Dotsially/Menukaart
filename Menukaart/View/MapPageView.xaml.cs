using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.ViewModel;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using PolylineEncoder.Net.Utility;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace Menukaart.View;

public partial class MapPageView : ContentPage
{
    private readonly IGeolocation geolocation;
    Location pointOfInterest;
    MapSpan userLocation;
    SightData poiList;
    const string googleApiKey = "AIzaSyBXG_XrA3JRTL58osjxd0DbqH563e2t84o";

    public MapPageView(IGeolocation geolocation)
    {
        this.geolocation = geolocation;
        poiList = new();
        InitializeComponent();

        Polyline testPolyline = new Polyline();

        userLocation = new MapSpan(new Location(0, 0), 0.01, 0.01);
        var sight = SightData.SightList.Last();

        pointOfInterest = sight.Location;
        map.IsShowingUser = true;
        Pin pin = new Pin() { Location = sight.Location, Label = sight.Name, Address = "" };
        pin.MarkerClicked += Pin_MarkerClicked;
        map.Pins.Add(pin);
        StartListening();

        //List<Location> polylinePoints = GetRoutePolyline(new Location(userLocation.LatitudeDegrees, userLocation.LongitudeDegrees), pointOfInterest).Result;

        //foreach(var polylinePoint in polylinePoints)
        //{

        //testPolyline.Add(polylinePoint);
        //}

        //map.AddLogicalChild(testPolyline);
    }

    //Start listening to user location
    private async Task<bool> StartListening()
    {
        GeolocationAccuracy accuracy = GeolocationAccuracy.High;
        var request = new GeolocationListeningRequest(accuracy);

        geolocation.LocationChanged += GeolocationLocationChanged;
        var success = await Geolocation.StartListeningForegroundAsync(request);
        return success;
    }

    void GeolocationLocationChanged(object sender, GeolocationLocationChangedEventArgs e)
    {
        Location location = new Location(e.Location.Latitude, e.Location.Longitude);

        double distance = Location.CalculateDistance(location, pointOfInterest, DistanceUnits.Kilometers);
        Debug.WriteLine(distance);
        if (distance <= 0.01)
        {
            Debug.WriteLine("you arrived");

        }

        userLocation = new MapSpan(location, 0.01, 0.01);
        map.MoveToRegion(userLocation);
    }

    private async void ReturnToRoutes(object sender, EventArgs e)
    {
    }

    private async void Pin_MarkerClicked(object sender, EventArgs e)
    {
        // This method will be called when a pin is clicked
        var pin = (Pin)sender;
        Console.WriteLine($"Pin {pin.Label} was clicked");

        Sight selectedSight = SightData.SightList.SingleOrDefault(sight => sight.Name == pin.Label.ToString());

        await GoToSightView(selectedSight);

    }

    private async Task GoToSightView(Sight sight)
    {
        await Navigation.PushAsync(new SightView(new MapPageViewModel(sight, Navigation))); // dont forget to add navigation to viewmodel
    }
    private async Task<List<Location>> GetRoutePolyline(Location userLocation, Location pointOfInterest)
    {
        using HttpClient client = new HttpClient();


        string requestURL = $"https://maps.googleapis.com/maps/api/directions/json?origin={userLocation.Latitude}%2C{userLocation.Longitude}&destination={pointOfInterest.Latitude}%2C{pointOfInterest.Longitude}&mode=walking&key={googleApiKey}";

        HttpResponseMessage response = await client.GetAsync(requestURL);

        JsonObject jsonResponse = await response.Content.ReadFromJsonAsync<JsonObject>();


        string encodedPolyline = jsonResponse!["routes"]!.AsArray()[0]!.AsObject()["overview_polyline"]!.AsObject()["points"]!.ToString();

        PolylineUtility decoder = new PolylineUtility();
        var coordinates = decoder.Decode(encodedPolyline);

        List<Location> locations = new List<Location>();

        foreach (var coordinate in coordinates)
        {
            locations.Add(new Location(coordinate.Latitude, coordinate.Longitude));
        }

        return locations;
    }


}