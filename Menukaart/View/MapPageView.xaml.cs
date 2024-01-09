using CommunityToolkit.Mvvm.Input;

using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.ViewModel;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using PolylineEncoder.Net.Utility;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using Menukaart.Model;
using System.Text.Json.Nodes;
using System.Net;
using System.Threading;
namespace Menukaart.View;

[QueryProperty(nameof(Route), "route")]
public partial class MapPageView : ContentPage
{
    private readonly IGeolocation geolocation;
    Location pointOfInterest;
    MapSpan userLocation;
    const string googleApiKey = "AIzaSyBXG_XrA3JRTL58osjxd0DbqH563e2t84o";
    double distance = 0;
    Session session;

    private RouteListPageModel _route;
    public RouteListPageModel Route
    {
        get => _route;
        set
        {
            _route = value;
            OnPropertyChanged();
        }
    }
    int routeEnumerator = 0;

    public MapPageView(IGeolocation geolocation)
    {
        this.geolocation = geolocation;
        InitializeComponent();
    }

    //Start listening to user location
    private async void StartListening()
    {
        GeolocationAccuracy accuracy = GeolocationAccuracy.Best;
        var request = new GeolocationListeningRequest(accuracy);

        geolocation.LocationChanged += GeolocationChanged;
        var success = await Geolocation.StartListeningForegroundAsync(request);
    }

    void GeolocationChanged(object sender, GeolocationLocationChangedEventArgs e)
    {
        Location location = new Location(e.Location.Latitude, e.Location.Longitude);

        double oldDistance = distance;
        distance = Location.CalculateDistance(location, pointOfInterest, DistanceUnits.Kilometers);
        Debug.WriteLine(distance);

        if (oldDistance == 0)
        {

        }
        else
        {
            double distanceWalked = oldDistance * 1000.0 - distance * 1000.0;
            session.distance = (int)distanceWalked;
        }



        if (distance <= 0.02)
        {
            ArrivedAtLocation();
        }

        userLocation = new MapSpan(location, 0.01, 0.01);
        map.MoveToRegion(userLocation);
    }

    void ArrivedAtLocation()
    {
        //sessie code 
        session.AddSight(Route.SightList[routeEnumerator].Id);
        
        if (routeEnumerator < Route.SightList.Count)
        {
            routeEnumerator++;
        }
        else
        {
            routeEnumerator = 0;
        }

        map.Pins.Clear();
        var newPoi = Route.SightList[routeEnumerator];
        map.Pins.Add(new Pin {
            Location = newPoi.Location,
            Label = newPoi.Name,
            Address = "" });
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
        HttpClient client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(5);

        List<Location> locations = [];
        Location landmarkLocation = pointOfInterest;

        //Nederlandse coordinaten zijn met comma. Google gebruikt punt.
        string userLocationURLString = $"{userLocation.Latitude.ToString().Replace(',', '.')}%2C{userLocation.Longitude.ToString().Replace(',', '.')}";
        string landmarkLocationURLString = $"{landmarkLocation.Latitude.ToString().Replace(',', '.')}%2C{landmarkLocation.Longitude.ToString().Replace(',', '.')}";

        string requestURL = $"https://maps.googleapis.com/maps/api/directions/json?origin={userLocationURLString}&destination={landmarkLocationURLString}&mode=walking&key={googleApiKey}";


        HttpResponseMessage response = await client.GetAsync(requestURL);

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            return [];
        }

        var jsonResponse = await response.Content.ReadFromJsonAsync<JsonObject>();

        if (jsonResponse!["status"]!.ToString() == "ZERO_RESULTS")
            throw new ApplicationException("No route possible");

        string encodedPolyline =
            jsonResponse!["routes"]!.AsArray()
            [0]!.AsObject()
            ["overview_polyline"]!.AsObject()
            ["points"]!.ToString();

        // Decode polyline using the NuGet package
        PolylineUtility decoder = new();
        var coordinates = decoder.Decode(encodedPolyline);

        // Add all positions of the route to a list
        foreach (var coordinate in coordinates)
        {
            locations.Add(new Location(coordinate.Latitude, coordinate.Longitude));
        }

        return locations;
    }


    private void Initialize(RouteListPageModel route)
    {
        Polyline testPolyline = new Polyline();
        session = new Session();
        userLocation = new MapSpan(new Location(0, 0), 0.01, 0.01);
        var poi = route.SightList[0];
        pointOfInterest = poi.Location;

        map.IsShowingUser = true;

        Pin pin = new Pin()
        {
            Location = poi.Location,
            Label = poi.Name,
            Address = ""
        };
        pin.MarkerClicked += Pin_MarkerClicked;
        map.Pins.Add(pin);

        List<Location> polylinePoints = GetRoutePolyline(new Location(userLocation.LatitudeDegrees, userLocation.LongitudeDegrees), pointOfInterest).Result;

        foreach (var polylinePoint in polylinePoints)
        {
            testPolyline.Add(polylinePoint);
        }

        map.AddLogicalChild(testPolyline);

        StartListening();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Initialize(Route);
    }

    async void StopSession(object sender, EventArgs args)
    {
       //Sla hier sessie op in database
       await Shell.Current.GoToAsync(nameof(View.RouteListPageView));
    }

    async void NavigateToTutorial(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(TutorialPageView));
    }
}