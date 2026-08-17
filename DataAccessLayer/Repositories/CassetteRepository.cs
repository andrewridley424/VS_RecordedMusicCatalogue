using System.Data;
using RecordedMusicCatalogue.DomainModel.Models;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using Dapper;
using System.Data.SqlClient;

namespace RecordedMusicCatalogue.DataAccessLayer.Repositories
{
    public class CassetteRepository : ICassetteRepository
    {
        public async Task<List<Cassette>> GetCassettes()
        {
            string query = "select id, title, artist, label, genre.name as genre from cassettes" +
                           " inner join genre on cassettes.genre_id = genre.genre_id";

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Cassette>(query)).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Cassette>();
            }
        }
    }
}
