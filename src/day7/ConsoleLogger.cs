using System;
using System.Collections.Generic;
using System.Text;

namespace day7Tests.Green
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }
}
