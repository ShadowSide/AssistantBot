using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace AssistantBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new BotSettings();
            var bot = new AssistantBot(settings);
            Console.ReadLine();
        }
    }
}
