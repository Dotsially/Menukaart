using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.Model;

namespace Menukaart.ViewModel
{
    public partial class TutorialPageViewModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<TutorialPageModel> _tutorialSections = new();

        public TutorialPageViewModel()
        {
            TutorialSections.Add( new()
            {
                Title = "Select a route",
                Description = "To get started, press the \"Start Route\" button. You'll now see a list of curated routes, each with a unique theme or culinary focus. Examples include \"Local Favorites,\" \"International Delights,\" or \"Vegetarian Wonders.\" scroll through the routes to explore the different options. Select a route and press the \"Start route\" button to get the directions to your first restaurant!",
                ImageName = "ic_route_list.png"
            });


            TutorialSections.Add(new()
            {
                Title = "Finding your way",
                Description = "Once you've selected a route, the app will provide a map with directions to the first restaurant. Follow the guidance to embark on your delicious journey. Arrive at the restaurant and the app will greet you with the details of that place.",
                ImageName = "ic_route.png"
            });

            TutorialSections.Add(new()
            {
                Title = "Bon appetit",
                Description = "Indulge in the culinary delights the restaurant offers, and savor the experience! After each stop, the app will guide you to the next venue until you've completed the entire route.",
                ImageName = "ic_restaurant.png"
            });

            TutorialSections.Add(new()
            {
                Title = "Session information",
                Description = "After completing a route or exiting, revisit your culinary journey by tapping \"Show passed Sessions.\" This feature shows details of completed routes, including the restaurants you've visited, the total distance that you've traveled and the time you've spend walking the route.",
                ImageName = "ic_session_statistics.svg"
            });

            TutorialSections.Add(new()
            {
                Title = "Stuck? Don't worry!",
                Description = "If you ever find yourself stuck or have questions about the app, don't worry! You can access the help menu by tapping the \"?\" button in the top right corner of the screen. This will take you back to these instructions and provide additional information to assist you. Happy dining!",
                ImageName = "ic_help.png"
            });
        }

        [RelayCommand]
        Task Back() => Shell.Current.GoToAsync("..");
    }
}
