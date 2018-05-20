using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot
{
    public class Bot
    {
        private TelegramBotClient BotClient { get; }
        
        public Bot()
        {
            BotClient = new TelegramBotClient("api key");
        }
        
        public async Task<string> TestApiAsync()
        {
            var me = await BotClient.GetMeAsync();
            return $"Hello! My name is {me.FirstName}";
        }

        public async Task<Update[]> GetUpdatesAsync()
        {
            var result = await BotClient.GetUpdatesAsync();
            return result;
        }
    }
}

