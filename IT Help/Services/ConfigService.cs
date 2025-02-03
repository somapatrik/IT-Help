using IT_Help.Models;
using System.IO;
using System.Text.Json;

namespace IT_Help.Services
{
    public class ConfigService
    {
        private string _fileName = "config.json";


        public async Task InitConfigFile()
        {
            if (!File.Exists(_fileName))
            {
                await CreateExampleFile();
            }
        }

        private async Task CreateExampleFile()
        {
            AppConfig config = AppConfig.CreateExample();

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_fileName, json);
        }

        public async Task<AppConfig?> GetConfig()
        {
            AppConfig? config = await JsonSerializer.DeserializeAsync<AppConfig>(File.OpenRead(_fileName));
            return config;
        }
    }
}
