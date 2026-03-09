using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace day6.excersise2
{
    public interface IMessageSender
    {
        void Send(string to, string msg);
    }
}
