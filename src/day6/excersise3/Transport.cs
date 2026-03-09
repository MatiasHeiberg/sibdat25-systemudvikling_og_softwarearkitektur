using System;
using System.Collections.Generic;
using System.Text;

namespace day6.excersise3
{
    public class Transport
    {
        public string VehicleType { get; set; }
        public IEngine Engine { get; set; }
        public bool HasAutopilot { get; set; }
        
        public Transport(IEngine engine, bool hasAutopilot)
        {
            Engine = engine;
            HasAutopilot = hasAutopilot;
        }

        public void Describe()
        {
            Console.WriteLine($"Motortype: {Engine}");
        }
    }
}
