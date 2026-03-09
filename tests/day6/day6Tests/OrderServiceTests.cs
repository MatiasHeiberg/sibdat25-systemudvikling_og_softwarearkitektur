using day6.excersise2;

namespace day6Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void SendConfirmation_TakesRecipientAndChannel_SendMessageViaChannelOnce()
        {
            IMessageSender channel = new FakeMessageSender();
            string to = "Bob Smith";
            int expected = 1;

            channel.Send(to, "Tak for din ordre!");
            int result = ((FakeMessageSender)channel).ConfirmationsSend;

            Assert.Equal(expected, result);
        }
    }
}
