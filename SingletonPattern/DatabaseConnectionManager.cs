using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class DatabaseConnectionManager
    {
        private static DatabaseConnectionManager _connectionManager;

        private static readonly object lockObject = new object();

        public bool IsOpen { get; set; }
        private DatabaseConnectionManager()
        {

        }

        public static DatabaseConnectionManager GetDatabaseConnectionManager()
        {
            lock(lockObject)
            {
                if (_connectionManager == null)
                {
                    _connectionManager = new DatabaseConnectionManager();
                }
                return _connectionManager;
            }

        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Connnection Status : {IsOpen}");
        }

    }
}
