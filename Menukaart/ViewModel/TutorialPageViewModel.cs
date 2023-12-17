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
                Title = "Tutorial title 1",
                Description = "Tutorial description",
                ImageName = "vvv_logo.png"
            });


            TutorialSections.Add(new()
            {
                Title = "Tutorial title 2",
                Description = "Tutorial description",
                ImageName = "vvv_logo.png"
            });

            TutorialSections.Add(new()
            {
                Title = "Tutorial title 3",
                Description = "Tutorial description",
                ImageName = "vvv_logo.png"
            });
        }

        [RelayCommand]
        Task Back() => Shell.Current.GoToAsync("..");

    }
}
