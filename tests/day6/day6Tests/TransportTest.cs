using day6;
using day6.excersise3;
using System;
using System.Collections.Generic;
using System.Text;

namespace day6Tests
{
    public class TransportTest
    {
        [Fact]
        public void DescribeTest_WhenElectric_ReturnCorrectDescription()
        {
            Transport t = new Transport(new ElectricEngine(), false);
            string expected = "Electric Car";

            string result = t.Describe();

            Assert.Equal<string>(result, expected);
        }
        [Fact]
        public void DescribeTest_WhenElectricAutopilot_ReturnCorrectDescription()
        {
            Transport t = new Transport(new ElectricEngine(), true);
            string expected = "Autopilot Electric Car";

            string result = t.Describe();

            Assert.Equal<string>(result, expected);
        }
        [Fact]
        public void DescribeTest_WhenCombustion_ReturnCorrectDescription()
        {
            Transport t = new Transport(new CombustionEngine(), false);
            string expected = "CombustionEngine Car";

            string result = t.Describe();

            Assert.Equal<string>(result, expected);
        }
        [Fact]
        public void DescribeTest_WhenCombustionAutopilot_ReturnCorrectDescription()
        {
            Transport t = new Transport(new CombustionEngine(), true);
            string expected = "Autopilot CombustionEngine Car";

            string result = t.Describe();

            Assert.Equal<string>(result, expected);
        }

    }
}
