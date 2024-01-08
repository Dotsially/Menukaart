using System.Diagnostics;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class DatabasePageView : ContentPage
{
    private DatabaseService _db;

	public DatabasePageView(DatabaseService databaseService)
	{
		InitializeComponent();
        _db = databaseService;
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        var context = new DatabasePageViewModel(_db);
        BindingContext = context;
    }
}