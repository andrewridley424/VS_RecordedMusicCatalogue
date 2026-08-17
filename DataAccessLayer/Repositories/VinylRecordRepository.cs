using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace RecordedMusicCatalogue.DataAccessLayer.Repositories
{
    internal class VinylRecordRepository : IVinylRecordRepository
    {
        public async Task<List<VinylRecord>> GetVinylRecords()
        {
           string query = "select id, title, artist, label, genre.name as genre, rpm, size, number_of_discs as NumberOfDiscs from vinyl_records" +
            " inner join genre on vinyl_records.genre_id = genre.genre_id";
           
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return  (await connection.QueryAsync<VinylRecord>(query)).ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<VinylRecord>();
            }
        }
    }
}
