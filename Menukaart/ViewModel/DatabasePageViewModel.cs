﻿using CommunityToolkit.Mvvm.ComponentModel;
using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Menukaart.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.ViewModel
{
    public class DatabasePageViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public DatabasePageViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            CreateMultipleEmptySessions(25);
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

        private void OnItemSelected(Session selectedSession)
        {
            if (selectedSession != null)
            {
                // TODO: navigatie naar de nieuwe pagina
                Debug.WriteLine($"clicked session {selectedSession.id}");
                Shell.Current.GoToAsync($"{nameof(SessionInfoPageView)}?id={selectedSession.id}");
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
