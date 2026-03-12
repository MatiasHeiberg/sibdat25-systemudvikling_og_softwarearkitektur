using day7Tests.Green;
using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests
{
    public class FakeLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG {DateTime.Now}]: {message}");
        }
    }
}
