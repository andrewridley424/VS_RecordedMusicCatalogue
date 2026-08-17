using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.DataAccessLayer.Contracts
{
   public interface ICdRepository
    {
        public Task<List<Cd>> GetCds();
    }
}
