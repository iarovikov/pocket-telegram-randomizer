using System;
using Xunit;

namespace TelegramBot.Test
{
    public class BotTest
    {
        [Fact]
        public async void PingTest()
        {
            var sut = new Bot();
            var result = await sut.TestApiAsync();

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetUpdatesTest()
        {
            var sut = new Bot();
            var result = await sut.GetUpdatesAsync();
            
            Assert.NotNull(result);
        }
    }
}