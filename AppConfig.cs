using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pis
{
    public class AppConfig
    {
        public Dictionary<string, string> ConnectionStrings { get; set; }
        public string DefaultConnection { get; set; }

        public static AppConfig Load()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "Automation");
            string configPath = Path.Combine(appFolder, "appsettings.json");

            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            if (!File.Exists(configPath))
            {
                var defaultConfig = new AppConfig
                {
                    ConnectionStrings = new Dictionary<string, string>
                    {
                        ["ISPr25-25_PiskunovDV"] = "server=cfif31.ru;database=ISPr25-25_PiskunovDV_Kursovaya;uid=ISPr25-25_PiskunovDV;pwd=ISPr25-25_PiskunovDV"
                    },
                    DefaultConnection = "ISPr25-25_PiskunovDV"
                };

                string json = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });

                File.WriteAllText(configPath, json, Encoding.UTF8);
            }

            var config = new ConfigurationBuilder()
                .SetBasePath(appFolder)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.Get<AppConfig>();
        }
    }
}
