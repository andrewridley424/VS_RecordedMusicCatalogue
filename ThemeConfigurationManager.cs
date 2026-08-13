using Newtonsoft.Json.Linq;
using System.Configuration;

namespace RecordedMusicCatalogue
{
    
        public static class ThemeConfigurationManager
        {
            public static JObject LoadThemeConfig()
            {
                string jsonFile = ConfigurationManager.ConnectionStrings["JsonFilePath"].ConnectionString;
                if (File.Exists(jsonFile))
                {
                    string config = File.ReadAllText(jsonFile);
                    return JObject.Parse(config);
                }
                return null;
            }
        }
}
