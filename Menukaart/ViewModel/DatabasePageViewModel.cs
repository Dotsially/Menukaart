using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.ViewModel
{
    class DatabasePageViewModel
    {
        private readonly DatabaseService _databaseService;
        
        private ListView _listView;
        
        public DatabasePageViewModel(DatabaseService databaseService, ListView listview) 
        {
            _databaseService = databaseService;
            _listView = listview;
            CreateMultipleEmptySessions(10);
            Task.Run(async () => {
                _listView.ItemsSource = await _databaseService.getSessions();
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

        private void OnItemClick(Session session) { 
            Debug.WriteLine(session);
        }
    }
}
