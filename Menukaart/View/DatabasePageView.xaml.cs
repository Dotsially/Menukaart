using System.Diagnostics;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;

namespace Menukaart.View;

public partial class DatabasePageView : ContentPage
{
    private readonly DatabaseService _databaseService;

	public DatabasePageView(DatabaseService databaseService)
	{
		InitializeComponent();
		_databaseService = databaseService;

        Task.Run(async () => { 
            listView.ItemsSource = await _databaseService.getSessions();
        });
    }

    //Test code
    private async Task CreateSession()
    {
        Session session = new Session();
        await _databaseService.CreateSession(session);

        session.AddSight(1);
        session.AddSight(1);
        session.AddSight(1);
        await _databaseService.UpdateSession(session);
        await _databaseService.UpdateSession(session);
        session.AddSight(2);
        await _databaseService.UpdateSession(session);
        session.RemoveSight(1);
        session.AddSight(3);
        await _databaseService.UpdateSession(session);

        await Task.Delay(1000);
        List<Datalink> a = await _databaseService.getDatalinks();
        foreach (var datalink in a)
        {
            Debug.WriteLine(datalink);
        }
    }
    
    // Test code
    private async void CreateMultipleEmptySessions(int count)
    {
        List<Session> list = new List<Session>();
        for (int i = 0; i < count; i++)
        {
            Session s = new Session()
            {
                id = i,
                date = DateTime.Now.AddDays(i),
                distance = i,
                time = i
            };

            list.Add(s);
        }

        await _databaseService.CreateSessions(list);
    }

    private void Temp(object? sender, ItemTappedEventArgs e)
    {
        throw new NotImplementedException();
    }
}