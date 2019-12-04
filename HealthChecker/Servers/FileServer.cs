using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    class FileServer : Server
    {
        public override bool HealthCheck()
        {
            return true;
        }
    }
}
