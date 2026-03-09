using day6.excersise2;
using System;
using System.Collections.Generic;
using System.Text;

namespace day6Tests
{
    public class FakeMessageSender : IMessageSender
    {
        public string to;
        public string message;
        public int ConfirmationsSend { get; set; } = 0;

        public void Send(string to, string msg)
        {
            ConfirmationsSend++;
            this. to = to;
            message = msg;
        }
    }
}
