using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace day6.excersise2
{
    class OrderService
    {
        IMessageSender _channel;

        public OrderService(IMessageSender channel)
        {
            _channel = channel;
        }

        public void SendConfirmation(string to)
        {
            string message = "Tak for din ordre!";
            _channel.Send(to, message);
        }
    }
}
