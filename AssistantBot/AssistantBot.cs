using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace AssistantBot
{
    class AssistantBot
    {
        private readonly TelegramBotClient _bot;
        public AssistantBot(BotSettingsDto settings)
        {
            _bot = new TelegramBotClient(settings.TelegramApiKey);
            var me = _bot.GetMeAsync().Result;
            Console.WriteLine($"My name '{me.Username}'");
        }
    }
}
