using System;
using System.Collections.Generic;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public required string Name { get; set; }

        public Genre(int genreId, string name) { GenreId = genreId; Name = name; }
        public Genre() { }  
    }
}
