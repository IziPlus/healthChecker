using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Servers
{
    public interface IServer
    {
       bool HealthCheck();
    }
}
