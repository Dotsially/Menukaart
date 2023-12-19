using System.Diagnostics;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.ViewModel;

namespace Menukaart.View;

public partial class DatabasePageView : ContentPage
{
    

	public DatabasePageView(DatabaseService databaseService)
	{
		InitializeComponent();
        BindingContext = new DatabasePageViewModel(databaseService);
    }

 

}