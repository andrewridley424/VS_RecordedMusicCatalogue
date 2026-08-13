using System.Configuration;

namespace RecordedMusicCatalogue.DataAccessLayer
{
    internal class ConnectionHelper
    {
        internal static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["RecordedMusicCatalogueConnectionString"].ConnectionString;
            }
        }
    }
}
