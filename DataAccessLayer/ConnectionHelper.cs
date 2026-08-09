using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

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
