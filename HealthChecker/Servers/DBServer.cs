
namespace HealthChecker.Servers
{
    public class DBServer :IServer
    {
        public DBServer(string connectionString, string dBQuery)
        {
            ConnectionString = connectionString;
            DbQuery = dBQuery;
        }
        public string ConnectionString { get;  }
        public string DbQuery { get;  }

        public bool HealthCheck()
        {
            return false;
        }
    }
}
