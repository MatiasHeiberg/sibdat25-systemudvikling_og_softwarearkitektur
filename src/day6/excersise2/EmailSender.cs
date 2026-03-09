using System;
using System.Collections.Generic;
using System.Text;

namespace day6.excersise2
{
    public class EmailSender : IMessageSender
    {
        public void Send(string to, string msg)
        {
            Console.WriteLine($"Email til {to}: {msg}");
        }
    }
}
