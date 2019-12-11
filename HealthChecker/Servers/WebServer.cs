using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    class WebServer : IServer
    {
        public int Port { get; }

        public bool HealthCheck()
        {
            throw new NotImplementedException();
        }
    }
}
