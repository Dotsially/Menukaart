using CommunityToolkit.Mvvm.ComponentModel;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.View;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Menukaart.ViewModel
{
    public class DatabasePageViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public DatabasePageViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            CreateSession();
            LoadSessions();
        }

        private ObservableCollection<Session> _sessions;
        public ObservableCollection<Session> Sessions
        {
            get => _sessions;
            set => SetProperty(ref _sessions, value);
        }

        private async void LoadSessions()
        {
            var sessions = await _databaseService.GetSessions();
            Sessions = new ObservableCollection<Session>(sessions);
        }


        private Command<Session> _itemSelectedCommand;
        public Command<Session> ItemSelectedCommand =>
            _itemSelectedCommand ?? (_itemSelectedCommand = new Command<Session>(OnItemSelected));

        private Session _selectedSession;
        public Session SelectedSession
        {
            get => _selectedSession;
            set => SetProperty(ref _selectedSession, value);
        }

        private async void OnItemSelected(Session selectedSession)
        {
            if (selectedSession != null)
            {
                var savedSights = await _databaseService.GetDatalinkFromSessionId(selectedSession.id);

                var navigationParameter = new Dictionary<string, object>
                    {
                        { "SelectedSession", selectedSession },
                        { "SavedSights", savedSights },
                    };
                Debug.WriteLine($"clicked session {selectedSession.id}");
                await Shell.Current.GoToAsync(nameof(SessionInfoPageView), navigationParameter);
            }
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
    }
}
