using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace RecordedMusicCatalogue.DataAccessLayer.Repositories
{
   public class TracksRepository : ITracksRepository
    {
        public async Task<List<Track>> GetTracks(RecordedMusicAlbum album)
        { 
           var query =$"select id, name, duration from tracks where {GetAlbumId(album.GetType().ToString())}={album.Id}";

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Track>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Track>();
            }

            static string GetAlbumId( string albumType)
            {
                var recordType = albumType;

                var recordId = "";
                if (recordType == "RecordedMusicCatalogue.DomainModel.Models.Cassette")
                    recordId = "cassette_id";
                else if (recordType == "RecordedMusicCatalogue.DomainModel.Models.Cd")
                    recordId = "cd_id";
                else
                    recordId = "vinyl_record_id";

                return recordId;
            }
        }
    }
}
