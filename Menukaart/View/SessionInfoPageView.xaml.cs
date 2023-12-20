using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.ViewModel;
using System.Diagnostics;

namespace Menukaart.View;

[QueryProperty(nameof(Session), "SelectedSession")]
[QueryProperty(nameof(SavedSights), "SavedSights")]
public partial class SessionInfoPageView : ContentPage
{
    private Session _session;
    public Session Session
    {
        get => _session;
        set
        {
            _session = value;
            OnPropertyChanged();
        }
    }

    private List<Datalink> _savedSights;
    public List<Datalink> SavedSights
    {
        get => _savedSights;
        set
        {
            _savedSights = value;
            OnPropertyChanged();
        }
    }


    public SessionInfoPageView()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        BindingContext = new SessionInfoPageViewModel(_session, _savedSights);
    }
}