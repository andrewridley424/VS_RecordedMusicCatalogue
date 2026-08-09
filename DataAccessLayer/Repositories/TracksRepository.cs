using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Data.SqlClient;

namespace RecordedMusicCatalogue.DataAccessLayer.Repositories
{
   public class TracksRepository : ITracksRepository
    {
        public async Task<List<Track>> GetTracks(VinylRecord vinylRecord)
        {
            string query =$"select id, name, duration from tracks where vinyl_record_id={vinylRecord.Id}";

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
        }
    }
}
