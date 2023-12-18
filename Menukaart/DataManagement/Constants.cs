using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement
{
    public static class Constants
    {
        // Breekt db
        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public const string DatabaseFileName = "TestSQLite.db3";
        public const string SessionTable = "session";
        public const string DatalinkTable = "datalink";

        public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);
    }
}
