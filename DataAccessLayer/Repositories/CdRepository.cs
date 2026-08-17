using RecordedMusicCatalogue.DomainModel.Models;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace RecordedMusicCatalogue.DataAccessLayer.Repositories
{
   public class CdRepository : ICdRepository
   {
       public async Task<List<Cd>> GetCds()
       {
           string query = "select id, title, artist, label, number_of_discs as NumberOfDiscs, genre.name as genre from cds" +
                          " inner join genre on cds.genre_id = genre.genre_id";

           try
           {
               using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
               {
                   return (await connection.QueryAsync<Cd>(query)).ToList();

               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
               return new List<Cd>();
           }
       }
   }
}
