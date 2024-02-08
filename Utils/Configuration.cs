using System.IO;

namespace TinyDRPC.Utils
{
    public class Configuration
    {

        public string topText { get; set; }
        public string bottomText {  get; set; }
        public string discordAppId { get; set; }
        public string button1Label { get; set; }
        public string button2Label { get; set; }
        public string button1Url { get; set; }
        public string button2Url { get; set; }
        public string largeImageKey { get; set; }
        public string largeImageText { get; set; }
        public string smallImageKey { get; set; }
        public bool enableButton1 { get; set; }
        public bool enableButton2 { get; set; }
        public bool runOnStartup { get; set; }
        public bool saveRunningState { get; set; }
        public bool lastStateIsRunning { get; set; }
        public bool runMinimized { get; set; }
        public bool minimizedAtFirst { get; set; }
        public bool checkUpdateOnStartup { get; set; }
    }

    public class ConfigurationManager
    {
        private static readonly string ConfigPathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TinyDRPC");
        private static readonly string ConfigFileName = Path.Combine(ConfigPathName, "TinyDRPC.ini");

        public Configuration LoadConfiguration()
        {
            if (File.Exists(ConfigFileName))
            {
                string[] lines = File.ReadAllLines(ConfigFileName);
                Configuration config = new Configuration();

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        SetProperty(config, key, value);
                    }
                }

                return config;
            }
            else
            {
                return CreateDefaultConfiguration();
            }
        }

        public void SaveConfiguration(Configuration config)
        {
            Directory.CreateDirectory(ConfigPathName);
            using (StreamWriter writer = new StreamWriter(ConfigFileName))
            {
                writer.WriteLine($"topText={config.topText}");
                writer.WriteLine($"bottomText={config.bottomText}");
                writer.WriteLine($"discordAppId={config.discordAppId}");
                writer.WriteLine($"button1Label={config.button1Label}");
                writer.WriteLine($"button2Label={config.button2Label}");
                writer.WriteLine($"button1Url={config.button1Url}");
                writer.WriteLine($"button2Url={config.button2Url}");
                writer.WriteLine($"largeImageKey={config.largeImageKey}");
                writer.WriteLine($"largeImageText={config.largeImageText}");
                writer.WriteLine($"smallImageKey={config.smallImageKey}");
                writer.WriteLine($"enableButton1={(config.enableButton1 ? "1" : "0")}");
                writer.WriteLine($"enableButton2={(config.enableButton2 ? "1" : "0")}");
                writer.WriteLine($"runOnStartup={(config.runOnStartup ? "1" : "0")}");
                writer.WriteLine($"saveRunningState={(config.saveRunningState ? "1" : "0")}");
                writer.WriteLine($"lastStateIsRunning={(config.lastStateIsRunning ? "1" : "0")}");
                writer.WriteLine($"runMinimized={(config.runMinimized ? "1" : "0")}");
                writer.WriteLine($"minimizedAtFirst={(config.minimizedAtFirst ? "1" : "0")}");
                writer.WriteLine($"checkUpdateOnStartup={(config.checkUpdateOnStartup ? "1" : "0")}");
            }
        }

        private void SetProperty(Configuration config, string key, string value)
        {
            switch (key)
            {
                case "topText":
                    config.topText = value;
                    break;
                case "bottomText":
                    config.bottomText = value;
                    break;
                case "discordAppId":
                    config.discordAppId = value;
                    break;
                case "button1Label":
                    config.button1Label = value;
                    break;
                case "button2Label":
                    config.button2Label = value;
                    break;
                case "button1Url":
                    config.button1Url = value;
                    break;
                case "button2Url":
                    config.button2Url = value;
                    break;
                case "largeImageKey":
                    config.largeImageKey = value;
                    break;
                case "largeImageText":
                    config.largeImageText = value;
                    break;
                case "smallImageKey":
                    config.smallImageKey = value;
                    break;
                case "enableButton1":
                    config.enableButton1 = (value == "1") ? true : false;
                    break;
                case "enableButton2":
                    config.enableButton2 = (value == "1") ? true : false;
                    break;
                case "runOnStartup":
                    config.runOnStartup = (value == "1") ? true : false;
                    break;
                case "saveRunningState":
                    config.saveRunningState = (value == "1") ? true : false;
                    break;
                case "lastStateIsRunning":
                    config.lastStateIsRunning = (value == "1") ? true : false;
                    break;
                case "runMinimized":
                    config.runMinimized = (value == "1") ? true : false;
                    break;
                case "minimizedAtFirst":
                    config.minimizedAtFirst = (value == "1") ? true : false;
                    break;
                case "checkUpdateOnStartup":
                    config.checkUpdateOnStartup = (value == "1") ? true : false;
                    break;
                default:
                    throw new Exception($"Unknown key: {key}");
            }
        }

        private Configuration CreateDefaultConfiguration()
        {
            Configuration config = new Configuration
            {
                topText = "Using TinyDRPC",
                bottomText = "powered by michioxd",
                discordAppId = "1184076027182452786",
                button1Label = "GitHub",
                button2Label = "",
                button1Url = "https://github.com/michioxd/TinyDRPC",
                button2Url = "",
                largeImageKey = "tinydrpc",
                largeImageText = "TinyDRPC",
                smallImageKey = "",
                enableButton1 = true,
                enableButton2 = false,
                runOnStartup = false,
                saveRunningState = true,
                lastStateIsRunning = false,
                runMinimized = true,
                minimizedAtFirst = false,
                checkUpdateOnStartup = true
            };
            SaveConfiguration(config);
            return config;
        }
    }
}