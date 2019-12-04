using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    class DBServer : Server
    {
        private string ConnectionString { get; set; }
        private string DBQuery { get; set; }
        public override bool HealthCheck()
        {
            return true;
        }
    }
}
