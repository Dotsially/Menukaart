using Menukaart.DataManagement.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement
{
    public interface IDatabaseService
    {
        public Task<List<Session>> GetSessions();

        public Task<Session> GetBySessionId(int id);

        public Task CreateSession(Session session);

        public Task<int> CreateSessions(List<Session> session);

        public Task UpdateSession(Session session);

        public Task<int> DeleteSession(Session session);

        public Task<List<Datalink>> getDatalinks();
        public Task<List<Datalink>> GetDatalinkFromSessionId(int id);
        public Task CreateDatalink(Datalink datalink);

        public Task DeleteDatalink(Datalink targetDatalink);
    }
}
