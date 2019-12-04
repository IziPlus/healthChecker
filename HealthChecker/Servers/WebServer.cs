using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    class WebServer : Server
    {
        public int Port { get; private set; }

        public override bool HealthCheck()
        {
            return false; 
        }
    }
}
