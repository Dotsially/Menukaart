using Menukaart.DataManagement;
using Menukaart.DataManagement.DataTypes;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestMenukaart.Class;

namespace UnitTestMenukaart.Tests
{
    public class DatabaseServiceTests
    {
        private static int _databaseDelay = 100;

        [Fact]
        public async void DatabaseServiceCanInitialize()
        {
            IDatabaseService db = new TestDatabaseService();
            Assert.NotNull(db);
        }

        [Fact]
        public async void DatabaseServiceCanCreateSession()
        {
            IDatabaseService db = new TestDatabaseService();
            Session session = new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195 };
            
            await Task.Delay(_databaseDelay);
            await db.CreateSession(session);
        }

        [Fact]
        public async void DatabaseServiceCanCreateMultipleSessionsAtOnce()
        {
            IDatabaseService db = new TestDatabaseService();

            List<Session> sessionList = new List<Session>(){
                new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195},
                new Session() { id = 2, date = DateTime.Now, time = 7201, distance = 42195},
                new Session() { id = 3, date = DateTime.Now, time = 7202, distance = 42195}
            };

            await Task.Delay(_databaseDelay);
            int createdRecords = await db.CreateSessions(sessionList);

            Assert.Equal(3, createdRecords);
        }

        [Fact]
        public async void DatabaseServiceCanRetrieveSession()
        {
            IDatabaseService db = new TestDatabaseService();
            Session session = new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195 };

            await Task.Delay(_databaseDelay);
            await db.CreateSession(session);
            await Task.Delay(_databaseDelay);

            Session databaseSession = await db.GetBySessionId(session.id);
            Assert.NotNull(databaseSession);
            Assert.Equal(session.id, databaseSession.id);
        }

        [Fact]
        public async void DatabaseServiceCanRetrieveAllSessions()
        {
            IDatabaseService db = new TestDatabaseService();
            await Task.Delay(_databaseDelay);
            List<Session> sessions = await db.GetSessions();

            Assert.NotNull(sessions);
            Assert.NotEmpty(sessions);
        }

        [Fact]
        public async void DatabaseServiceCanDeleteSession()
        {
            IDatabaseService db = new TestDatabaseService();
            Session session = new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195 };

            await Task.Delay(_databaseDelay);
            await db.CreateSession(session);
            await Task.Delay(_databaseDelay);

            int deletedRows = await db.DeleteSession(session);
            Assert.Equal(1, deletedRows);
        }

        [Fact]
        public async void DatabaseServiceCanUpdateSession()
        {
            IDatabaseService db = new TestDatabaseService();
            Session session = new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195 };
            await Task.Delay(_databaseDelay);
            await db.CreateSession(session);

            session.distance += 42195;
            session.time += 7200;
            session.AddSight(1);
            session.AddSight(2);
            session.AddSight(3);

            await db.UpdateSession(session);

            var databaseSession = await db.GetBySessionId(session.id);
            var list = await db.GetDatalinkFromSessionId(session.id);

            Assert.NotNull(databaseSession);
            Assert.Equal(session.distance, databaseSession.distance);
            Assert.Equal(session.time, databaseSession.time);

            foreach (var link in list)
            {
                Assert.Contains(link.sight_id, session.sightIdList);
            }
        }

        [Fact]
        public async void DatabaseServiceCanCreateDatalink()
        {
            IDatabaseService db = new TestDatabaseService();
            Datalink datalink = new Datalink() { id = 1, session_id = 1, sight_id = 1 };

            await db.CreateDatalink(datalink);
        }

        [Fact]
        public async void DatabaseServiceCanRetrieveAllDatalinks()
        {
            IDatabaseService db = new TestDatabaseService();
            List<Datalink> sessions = await db.getDatalinks();

            Assert.NotNull(sessions);
            Assert.NotEmpty(sessions);
        }

        [Fact]
        public async void DatabaseServiceCanRetrieveDatalinkFromSessionId()
        {
            IDatabaseService db = new TestDatabaseService();

            Session session = new Session() { id = 1, date = DateTime.Now, time = 7200, distance = 42195 };
            await db.CreateSession(session);
            await Task.Delay(_databaseDelay);
            
            Datalink datalink = new Datalink() { id = 1, session_id = session.id, sight_id = 1 };
            await db.CreateDatalink(datalink);
            await Task.Delay(_databaseDelay);

            var databaseLinks = await db.GetDatalinkFromSessionId(datalink.session_id);

            Assert.NotNull(databaseLinks);
            Assert.NotEmpty(databaseLinks);

            foreach ( var link in databaseLinks )
            {
                Assert.NotNull(link);
                Assert.Equal(link.id, datalink.id);
            }
        }


    }
}
