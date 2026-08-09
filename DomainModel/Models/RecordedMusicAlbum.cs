using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
   public class RecordedMusicAlbum
    {
        public required int Id { get; set; }
        public required string  Title { get; set; }
        public required string Artist { get; set; }
        public required string  Genre { get; set; } 

        public  RecordedMusicAlbum( int id, string title, string artist, string genre)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Genre = genre;
        }
        public RecordedMusicAlbum() { }
    }

}
