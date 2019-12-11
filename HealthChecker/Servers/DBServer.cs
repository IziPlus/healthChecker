using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    public class DBServer 
    {
        public DBServer(string connectionString, string dBQuery)
        {
            ConnectionString = connectionString;
            DBQuery = dBQuery;
        }
        public string ConnectionString { get;  }
        public string DBQuery { get;  }

        public bool HealthCheck()
        {
            return false;
        }
    }
}
