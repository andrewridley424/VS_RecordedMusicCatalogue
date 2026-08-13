using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.DataAccessLayer.Contracts
{
    public interface IVinylRecordRepository
    {
        public  Task<List<VinylRecord>> GetVinylRecords();
    }
}
