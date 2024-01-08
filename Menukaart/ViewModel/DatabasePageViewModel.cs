using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.View;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Menukaart.ViewModel
{
    public partial class DatabasePageViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public DatabasePageViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            CreatePlaceholderSession();
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

        private bool _isProcessingSelection;

        private async void OnItemSelected(Session selectedSession)
        {
            if (_isProcessingSelection)
            {
                return; // Ignore if the selection is already being processed
            }

            try
            {
                _isProcessingSelection = true;

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

                    // Clear the selection after navigation
                    SelectedSession = null;
                }
            }
            finally
            {
                _isProcessingSelection = false;
            }
        }

        [RelayCommand]
        Task NavigateToTutorial() => Shell.Current.GoToAsync(nameof(TutorialPageView));

        [RelayCommand]
        Task Back() => Shell.Current.GoToAsync("..");



        //Test code
        private async Task CreatePlaceholderSession()
        {
            var sessions = await _databaseService.GetSessions();
            if (sessions.Count != 0)
                return;


            Session session = new Session();
            await _databaseService.CreateSession(session);

            session.time += 20;
            session.distance = 9439;

            for (int i = 1; i < 20; i++)
            {
                session.AddSight(i);
            }
            await _databaseService.UpdateSession(session);

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
