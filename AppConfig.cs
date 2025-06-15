using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pis
{
    public class AppConfig
    {
        public Dictionary<string, string> ConnectionStrings { get; set; }
        public string DefaultConnection { get; set; }

        public static AppConfig Load()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config.Get<AppConfig>();
        }
    }
}
