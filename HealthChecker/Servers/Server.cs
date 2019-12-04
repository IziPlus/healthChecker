using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    public abstract class Server
    {
        public abstract bool HealthCheck();
    }
}
