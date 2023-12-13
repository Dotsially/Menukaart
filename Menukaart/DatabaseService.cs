using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menukaart
{
    public class DatabaseService
    {
        public const string DatabaseFilename = "TestSQLite.db3";
        private readonly SQLiteAsyncConnection _connection;

        public DatabaseService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename));
            _connection.CreateTableAsync<Session>();
        }

        public async Task<List<Session>> getSessions()
        {
            return await _connection.Table<Session>().ToListAsync();
        }

        public async Task<Session> getById(int id)
        {
            return await _connection.Table<Session>().Where(session => session.id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Session session)
        {
            await _connection.InsertAsync(session);
        }

        public async Task Update(Session session)
        {
            await _connection.UpdateAsync(session);
        }

        public async Task Delete(Session session)
        {
            await _connection.DeleteAsync(session);
        }
    }
}
