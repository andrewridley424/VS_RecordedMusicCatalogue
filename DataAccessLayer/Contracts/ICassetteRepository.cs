using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.DataAccessLayer.Contracts
{
   public interface ICassetteRepository
    {
        public Task<List<Cassette>> GetCassettes();
    }
}
