using System;
using System.Collections.Generic;
using System.Text;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.DataAccessLayer.Contracts
{
    public interface IVinylRecordRepository
    {
        public  Task<List<VinylRecord>> GetVinylRecords();
    }
}
