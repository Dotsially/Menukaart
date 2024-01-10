using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.Model;
using Menukaart.ViewModel;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Plugin.LocalNotification;
using PolylineEncoder.Net.Utility;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Net;
using System.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using Menukaart.DataManagement;
using Plugin.LocalNotification;

namespace Menukaart.View;

[QueryProperty(nameof(Route), "route")]
[QueryProperty(nameof(DatabaseService), "DatabaseService")]
public partial class MapPageView : ContentPage
{
    private readonly IGeolocation geolocation;
    Location pointOfInterest;
    MapSpan userLocation;
    const string googleApiKey = "AIzaSyBXG_XrA3JRTL58osjxd0DbqH563e2t84o";
    double distanceToDestination = 0;
    Location prevLocation;
    Session session;
    DateTime starttime;

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

    private DatabaseService _databaseService;
    public DatabaseService DatabaseService
    {
        get => _databaseService;
        set
        {
            _databaseService = value;
            OnPropertyChanged();
        }
    }

    public MapPageView(IGeolocation geolocation)
    {
        this.geolocation = geolocation;
        starttime = DateTime.Now;
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

    async void GeolocationChanged(object sender, GeolocationLocationChangedEventArgs e)
    {
        Location location = new Location(e.Location.Latitude, e.Location.Longitude);
        if (prevLocation == null) prevLocation = location;

        distanceToDestination = Location.CalculateDistance(location, pointOfInterest, DistanceUnits.Kilometers);
        Debug.WriteLine($"DISTANCE: {distanceToDestination}");

        var distance = (int)(Location.CalculateDistance(location, prevLocation, DistanceUnits.Kilometers) * 1000d);
        session.distance += distance;

        if (distanceToDestination <= 0.02)
        {
            ArrivedAtLocation();
        }

        userLocation = new MapSpan(location, 0.01, 0.01);

        map.MapElements.Clear();
        Polyline polyline = new Polyline();
        polyline.StrokeWidth = 7;

        List<Location> polylinePoints = GetRoutePolyline(location, pointOfInterest).GetAwaiter().GetResult();
        Debug.WriteLine("POLY " + polylinePoints.Count);

        foreach (var polylinePoint in polylinePoints)
        {
            polyline.Geopath.Add(polylinePoint);
        }

        map.MapElements.Add(polyline);

        map.MoveToRegion(userLocation);
        prevLocation = location;
    }

    private async Task GenerateNotification(Sight sight)
    {
        if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
        {
            await LocalNotificationCenter.Current.RequestNotificationPermission();
        }

        var notification = new NotificationRequest
        {
            NotificationId = 100,
            Title = $"You reached {sight.Name}!",
            Description = "You have reached your location!",

            Schedule =
         {
             NotifyTime = DateTime.Now // Used for Scheduling local notification, if not specified notification will show immediately.
         }
        };
        await LocalNotificationCenter.Current.Show(notification);
    }
        void ArrivedAtLocation()
    {

        Sight destinationSight = Route.SightList[routeEnumerator];
        session.AddSight(destinationSight.Id);
        _ = GenerateNotification(destinationSight);
        if (routeEnumerator < Route.SightList.Count - 1)
        {
            routeEnumerator++;
        }
        else
        {
            routeEnumerator = 0;
        }

        map.Pins.Clear();
        var newPoi = Route.SightList[routeEnumerator];
        map.Pins.Add(new Pin
        {
            Location = newPoi.Location,
            Label = newPoi.Name,
            Address = ""
        });
    }
    private async void Pin_MarkerClicked(object sender, EventArgs e)
    {
        // This method will be called when a pin is clicked
        var pin = (Pin)sender;
        Console.WriteLine($"Pin {pin.Label} was clicked");

        Sight selectedSight = SightData.SightList.SingleOrDefault(sight => sight.Name == pin.Label.ToString());

        await GoToSightView(selectedSight);

    }

    private async Task GenerateNotification(Sight sight)
    {
        if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
        {
            await LocalNotificationCenter.Current.RequestNotificationPermission();
        }

        var notification = new NotificationRequest
        {
            NotificationId = 100,
            Title = $"You reached {sight.Name}!",
            Description = "You have reached your location!",

            Schedule =
         {
             NotifyTime = DateTime.Now // Used for Scheduling local notification, if not specified notification will show immediately.
         }
        };
        await LocalNotificationCenter.Current.Show(notification);
    }



    private async Task GoToSightView(Sight sight)
    {
        await Navigation.PushAsync(new SightView(new MapPageViewModel(sight, Navigation))); // dont forget to add navigation to viewmodel
    }
    private async Task<List<Location>> GetRoutePolyline(Location userLocation, Location pointOfInterest)
    {
#if __ANDROID__
        HttpClient client = new HttpClient(new Xamarin.Android.Net.AndroidMessageHandler());
#else
        HttpClient client = new HttpClient();
#endif

        List<Location> locations = new List<Location>();
        Location landmarkLocation = pointOfInterest;

        //Nederlandse coordinaten zijn met comma. Google gebruikt punt.
        string userLocationURLString = $"{userLocation.Latitude.ToString().Replace(',', '.')}%2C{userLocation.Longitude.ToString().Replace(',', '.')}";
        string landmarkLocationURLString = $"{landmarkLocation.Latitude.ToString().Replace(',', '.')}%2C{landmarkLocation.Longitude.ToString().Replace(',', '.')}";

        string requestURL = $"https://maps.googleapis.com/maps/api/directions/json?origin={userLocationURLString}&destination={landmarkLocationURLString}&mode=walking&key={googleApiKey}";

        var response = client.GetAsync(requestURL).GetAwaiter().GetResult();

        if (!response.IsSuccessStatusCode)
        {
            Trace.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");

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

        PolylineUtility decoder = new();
        var coordinates = decoder.Decode(encodedPolyline);

        foreach (var coordinate in coordinates)
        {
            locations.Add(new Location(coordinate.Latitude, coordinate.Longitude));
        }

        return locations;
    }


    private void Initialize(RouteListPageModel route)
    {
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
        Debug.WriteLine(session);

        bool saveSession = await DisplayAlert("Save?", "Would you like to save this session?", "Yes", "No");

        if (saveSession)
        {
            var timespent = DateTime.Now - starttime;
            session.time = (int)timespent.TotalSeconds;

            await _databaseService.CreateSession(session);
            await _databaseService.UpdateSession(session);
        }

        await Shell.Current.GoToAsync(nameof(View.RouteListPageView));
    }

    async void NavigateToTutorial(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(TutorialPageView));
    }
}