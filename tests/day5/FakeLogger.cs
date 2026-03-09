using Microsoft.Testing.Platform.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger = OrderSystem.ILogger;

namespace OrderSystemTest
{
    public class FakeLogger : OrderSystem.ILogger
    {
        private List<string> _logs = [];
        void MyLogger.Log(string message)
        {
                _logs.Add(message);
        }
    }
}
