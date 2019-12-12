using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    public class WebServer : IServer
    {
        public WebServer(string url)
        {
            Url = url;
        }
        public string Url { get; }

        public bool HealthCheck()
        {
            return true;
        }
    }
}
