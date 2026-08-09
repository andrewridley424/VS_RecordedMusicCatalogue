using System;
using System.Collections.Generic;
using System.Text;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.DataAccessLayer.Contracts
{
   public interface ITracksRepository
    {
        public Task<List<Track>> GetTracks(VinylRecord vinylRecord);
    }
}
