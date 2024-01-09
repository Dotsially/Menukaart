using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMenukaart.Class
{
    public class TestDatabaseService : IDatabaseService
    {
        private readonly SQLiteAsyncConnection _connection;

        public TestDatabaseService()
        {
            string databasePath = Path.Combine(Directory.GetCurrentDirectory(), "UnitTestSQLDB.db3");
            _connection = new SQLiteAsyncConnection(databasePath);

            Task.Run(async () => await Init());
        }

        public async Task Init()
        {
            await _connection.CreateTablesAsync<Session, Datalink>();
        }


        public async Task<List<Session>> GetSessions()
        {
            return await _connection.Table<Session>().ToListAsync();
        }

        public async Task<Session> GetBySessionId(int id)
        {
            return await _connection.Table<Session>().Where(session => session.id == id).FirstOrDefaultAsync();
        }

        public async Task CreateSession(Session session)
        {
            await _connection.InsertAsync(session);
        }

        public async Task<int> CreateSessions(List<Session> session)
        {
            return await _connection.InsertAllAsync(session);
        }

        public async Task UpdateSession(Session session)
        {
            await _connection.UpdateAsync(session);

            List<Datalink> savedSights = await GetDatalinkFromSessionId(session.id);

            // Numbers in sessionlist but not in savedSights
            IEnumerable<int> numbersOnlyInList1 = session.sightIdList.Except(savedSights.Select(dl => dl.sight_id));

            // Numbers in savedSight but not in sessionList
            IEnumerable<Datalink> datalinksOnlyInList2 = savedSights.Where(dl => !session.sightIdList.Contains(dl.sight_id));

            foreach (int number in numbersOnlyInList1)
            {
                CreateDatalink(new Datalink() { session_id = session.id, sight_id = number });
            }

            foreach (Datalink datalink in datalinksOnlyInList2)
            {
                DeleteDatalink(datalink);
            }
        }

        public async Task<int> DeleteSession(Session session)
        {
            return await _connection.DeleteAsync(session);
        }

        public async Task<List<Datalink>> getDatalinks()
        {
            return await _connection.Table<Datalink>().ToListAsync();
        }
        public async Task<List<Datalink>> GetDatalinkFromSessionId(int id)
        {
            var datalinks = await _connection.Table<Datalink>()
                .ToListAsync();

            return datalinks
                .Where(datalink => datalink != null)
                .Where(datalink => datalink.session_id == id)
                .ToList();

        }
        public async Task CreateDatalink(Datalink datalink)
        {
            await _connection.InsertAsync(datalink);
        }

        public async Task DeleteDatalink(Datalink targetDatalink)
        {
            var datalinksToDelete = await _connection.Table<Datalink>()
                .Where(datalink => datalink.sight_id == targetDatalink.sight_id && datalink.session_id == targetDatalink.session_id)
                .ToListAsync();

            foreach (var datalink in datalinksToDelete)
            {
                await _connection.DeleteAsync(datalink);
            }
        }
    }
}
