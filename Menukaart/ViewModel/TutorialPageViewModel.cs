using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Menukaart.Model;

namespace Menukaart.ViewModel
{
    public partial class TutorialPageViewModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<TutorialPageModel> _tutorialSections = new();

        public TutorialPageViewModel()
        {
            _tutorialSections.Add( new()
            {
                Title = "Tutorial title",
                Description = "Tutorial description",
                ImageName = "vvv_logo.png"
            });
        }
    }
}
