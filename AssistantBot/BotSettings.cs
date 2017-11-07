using AssistantBot.Reflection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantBot
{
    class BotSettings: BotSettingsDto
    {
        public string Home
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            }
        }

        public BotSettings()
        {
            _settingFilePath = Path.Combine(Home, ".AssistantBot", "BotSettings.json");
            Console.WriteLine($"Settings file: '{_settingFilePath}'");
            Load();
        }

        private void Load()
        {
            var settings = JsonConvert.DeserializeObject<BotSettingsDto>(File.ReadAllText(_settingFilePath));
            Utilities.CopyDto(settings, this);
        }

        private readonly string _settingFilePath; 
    }
}
