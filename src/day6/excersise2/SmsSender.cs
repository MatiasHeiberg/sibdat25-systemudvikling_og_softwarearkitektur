using System;
using System.Collections.Generic;
using System.Text;

namespace day6.excersise2
{
    public class SmsSender : IMessageSender
    {
        public void Send(string to, string msg)
        {
            Console.WriteLine($"Email to {to}: {msg}");
        }
    }
}
