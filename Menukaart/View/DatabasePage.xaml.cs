using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;

namespace Menukaart.View;

public partial class DatabasePage : ContentPage
{
    private readonly DatabaseService _databaseService;

	public DatabasePage(DatabaseService databaseService)
	{
		InitializeComponent();
		_databaseService = databaseService;

        Task.Run(async () => await _databaseService.Wipe());

        List<Session> list = new List<Session>();
        for (int i = 0; i < 25; i++)
            {
                Session s = new Session()
                {
                    date = DateTime.Now.AddDays(i),
                    distance = i,
                    time = i
                };

                list.Add(s);
            }

        Task.Run(async () =>
        {
            await _databaseService.Create(list);
            listView.ItemsSource = await _databaseService.getSessions();
        });
    }

    private void Temp(object? sender, ItemTappedEventArgs e)
    {
        throw new NotImplementedException();
    }
}